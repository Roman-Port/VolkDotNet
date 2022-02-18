using System;
using System.Collections.Generic;
using System.Text;

namespace VolkDotNetGenerator.Kernels
{
    class VolkKernelDefinitionArg
    {
        public VolkKernelDefinitionArg(string name, string type)
        {
            this.name = name;
            this.type = type;
        }

        private string name;
        private string type;

        public string Name
        {
            get
            {
                //Make sure it's not a reserved keyword
                if (name == "in" || name == "out")
                    return "_" + name;
                else
                    return name;
            }
        }

        public string CSharpType
        {
            get
            {
                //Verify flags and get the raw type
                string type = VerifyFlags();

                //Determine pointer depth and trim off the characters
                int pointerDepth = 0;
                while (type.EndsWith('*'))
                {
                    pointerDepth++;
                    type = type.Substring(0, type.Length - 1);
                }

                //Convert
                type = CSharpTypeConverter.ConvertToCSharp(type);

                //Add pointer tags back
                for (int i = 0; i < pointerDepth; i++)
                    type += "*";

                return type;
            }
        }

        private string VerifyFlags()
        {
            string[] parts = type.Split(' ');
            for (int i = 0; i < parts.Length - 1; i++)
            {
                if (parts[i] != "const" && parts[i] != "unsigned")
                    throw new Exception("Unknown arg flag: " + parts[i]);
            }
            return parts[parts.Length - 1];
        }
    }
}
