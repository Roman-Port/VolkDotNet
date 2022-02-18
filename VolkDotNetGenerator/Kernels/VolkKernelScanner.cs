using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace VolkDotNetGenerator.Kernels
{
    class VolkKernelScanner
    {
        public static List<VolkKernelDefinition> ScanKernels(string volkSourceDir)
        {
            //Start Python shell
            Process py = Process.Start(new ProcessStartInfo
            {
                FileName = "python",
                WorkingDirectory = volkSourceDir + Path.DirectorySeparatorChar + "gen" + Path.DirectorySeparatorChar,
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardInput = true
            });

            //Run Python commands
            py.StandardInput.WriteLine("import volk_kernel_defs");
            py.StandardInput.WriteLine("for k in volk_kernel_defs.kernels:");
            py.StandardInput.WriteLine("    print (k.name + \"|\" + k.arglist_types + \"|\" + k.arglist_names + \"\\n\")");
            py.StandardInput.WriteLine("");
            py.StandardInput.Close();

            //Scan output for our format
            List<VolkKernelDefinition> results = new List<VolkKernelDefinition>();
            string line = py.StandardOutput.ReadLine();
            while (line != null)
            {
                //Split
                string[] parts = line.Split('|');
                if (parts.Length != 3)
                    throw new Exception("Failed to parse Python output.");

                //Add
                results.Add(new VolkKernelDefinition(parts[0], parts[1], parts[2]));

                //Scan next. For some reason we have to skip every other line, not sure why
                py.StandardOutput.ReadLine();
                line = py.StandardOutput.ReadLine();
            }

            return results;
        }
    }
}
