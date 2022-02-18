using System;
using System.Runtime.InteropServices;
using VolkDotNetGenerator.Kernels;

namespace VolkDotNetGenerator
{
    unsafe class Program
    {
        static unsafe void Main(string[] args)
        {
            //Scan kernels
            var kernels = VolkKernelScanner.ScanKernels(@"C:\Users\Roman\source\repos\volk_\");

            //Begin writing
            using (VolkCodeWriter writer = new VolkCodeWriter(@"C:\Users\Roman\source\repos\VolkDotNet\VolkDotNet\Generated\"))
            {
                //Write non-kernel functions
                writer.WriteFunction("volk_get_alignment", "volk_get_alignment", "IntPtr", "");
                writer.WriteFunction("volk_malloc", "volk_malloc", "IntPtr", "IntPtr size, IntPtr alignment");
                writer.WriteFunction("volk_free", "volk_free", "void", "IntPtr buffer");

                //Write each kernel
                foreach (var k in kernels)
                {
                    writer.WriteKernel(k.Name, k.Name, "void", k.CreateCSharpArgList());
                }
                
            }
        }
    }
}
