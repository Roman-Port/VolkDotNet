using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace VolkDotNetGenerator
{
    public class VolkCodeWriter : IDisposable
    {
        public VolkCodeWriter(string generatedDir)
        {
            fileDelegates = CreateStaticClassFile(generatedDir, "VolkDelegates");
            fileFunctions = CreateStaticClassFile(generatedDir, "VolkFunctions");
            fileKernels = CreateStaticClassFile(generatedDir, "VolkKernels");
        }

        private CSharpFileWriter fileDelegates;
        private CSharpFileWriter fileFunctions;
        private CSharpFileWriter fileKernels;

        private static CSharpFileWriter CreateStaticClassFile(string dir, string className)
        {
            CSharpFileWriter writer = new CSharpFileWriter(dir + Path.DirectorySeparatorChar + className + ".cs");
            writer.WriteLine("using System;");
            writer.WriteLine("using VolkDotNet.Internal;");
            writer.WriteLine("");
            writer.WriteLine("namespace VolkDotNet");
            writer.WriteLine("{");
            writer.Enter();
            writer.WriteLine("public unsafe class " + className);
            writer.WriteLine("{");
            writer.Enter();
            return writer;
        }

        private static void CloseStaticClassFile(CSharpFileWriter writer)
        {
            writer.Leave();
            writer.WriteLine("}");
            writer.Leave();
            writer.WriteLine("}");
            writer.Dispose();
        }

        private static string StripArgs(string args)
        {
            //Removes the type off of each arg
            string[] argsList = args.Split(',');
            string result = "";
            for (int i = 0; i < argsList.Length; i++)
            {
                //Split up this
                string[] argData = argsList[i].Trim().Split(' ');
                if (argData.Length != 2)
                    throw new Exception("Invalid args!");

                //Add just the name
                result += argData[1];

                //Add comma as neded
                if (i != argsList.Length - 1)
                    result += ", ";
            }
            return result;
        }

        private string WriteDelegate(string name, string returnType, string args)
        {
            string delegateName = "__d_" + name;
            fileDelegates.WriteLine($"public delegate {returnType} {delegateName}({args});");
            return "VolkDelegates." + delegateName;
        }

        public void WriteFunction(string name, string entryPoint, string returnType, string args)
        {
            //Create the delegate
            string delegateName = WriteDelegate(name, returnType, args);

            //Write the function
            fileFunctions.WriteLine($"public static {delegateName} {name} = VolkNative.volk.GetMethod<{delegateName}>(\"{entryPoint}\");");
        }

        public void WriteKernel(string name, string entryPoint, string returnType, string args)
        {
            //Convert the args list to a call with the same names
            string caller = StripArgs(args);

            //Create the delegate
            string delegateName = WriteDelegate(name, returnType, args);

            //Write constant
            string constantName = $"_EP_{name.ToUpper()}";
            fileKernels.WriteLine($"private const string {constantName} = \"{entryPoint}\";");

            //Write the function and initializer
            fileKernels.WriteLine($"public static {delegateName} {name} = ({args}) =>");
            fileKernels.WriteLine("{");
            fileKernels.Enter();
            if (returnType == "void")
                fileKernels.WriteLine($"VolkNative.volk.GetResolvedMethodPointer<{delegateName}>({constantName})({caller});");
            else
                fileKernels.WriteLine($"{returnType} temp = VolkNative.volk.GetResolvedMethodPointer<{delegateName}>({constantName})({caller});");
            fileKernels.WriteLine($"{name} = VolkNative.volk.GetResolvedMethodPointer<{delegateName}>({constantName});");
            if (returnType != "void")
                fileKernels.WriteLine("return temp;");
            fileKernels.Leave();
            fileKernels.WriteLine("};");
        }

        public void Dispose()
        {
            CloseStaticClassFile(fileDelegates);
            CloseStaticClassFile(fileFunctions);
            CloseStaticClassFile(fileKernels);
        }
    }
}
