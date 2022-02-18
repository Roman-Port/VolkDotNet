using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace VolkDotNet.Internal
{
    static class VolkPlatformNative
    {
        /* WINDOWS-ONLY */

        [DllImport("kernel32.dll", EntryPoint = "LoadLibrary")]
        public static extern IntPtr Win_LoadLibrary(string lib);

        [DllImport("kernel32.dll", EntryPoint = "GetProcAddress")]
        public static extern IntPtr Win_GetProcAddress(IntPtr module, string proc);

        /* LINUX-ONLY */

        [DllImport("libdl.so", EntryPoint = "dlopen")]
        public static extern IntPtr Unix_LoadLibrary(string lib, int flags);

        [DllImport("libdl.so", EntryPoint = "dlsym")]
        public static extern IntPtr Unix_GetProcAddress(IntPtr module, string proc);

        /* CROSS-PLATFORM NATIVE CALLS */

        public static bool TryLoadLibrary(string lib, out IntPtr result)
        {
            //Run
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                result = Win_LoadLibrary(lib);
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                result = Unix_LoadLibrary(lib, 2);
            else
                throw new PlatformNotSupportedException();

            //Check
            return result != IntPtr.Zero;
        }

        public static bool TryGetProcAddress(IntPtr module, string proc, out IntPtr result)
        {
            //Run
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                result = Win_GetProcAddress(module, proc);
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                result = Unix_GetProcAddress(module, proc);
            else
                throw new PlatformNotSupportedException();

            //Check
            return result != IntPtr.Zero;
        }
    }
}
