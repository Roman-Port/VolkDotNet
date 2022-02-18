using System;
using System.Collections.Generic;
using System.Text;

namespace VolkDotNetGenerator.Kernels
{
    class VolkKernelDefinition
    {
        public VolkKernelDefinition(string name, string argTypes, string argNames)
        {
            //Set
            this.name = name;

            //Parse args
            string[] argTypesList = argTypes.Split(',');
            string[] argNamesList = argNames.Split(',');
            if (argTypesList.Length != argNamesList.Length)
                throw new Exception("Inconsistent arg list.");
            args = new VolkKernelDefinitionArg[argTypesList.Length];
            for (int i = 0; i < args.Length; i++)
                args[i] = new VolkKernelDefinitionArg(argNamesList[i].Trim(), argTypesList[i].Trim());
        }

        private string name;
        private VolkKernelDefinitionArg[] args;

        public string Name => name;
        public string CreateCSharpArgList()
        {
            string result = "";
            for (int i = 0; i < args.Length; i++)
            {
                //Add
                result += args[i].CSharpType + " " + args[i].Name;

                //Add comma as needed
                if (i != args.Length - 1)
                    result += ", ";
            }
            return result;
        }
    }
}
