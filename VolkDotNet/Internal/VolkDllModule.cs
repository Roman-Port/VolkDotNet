using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace VolkDotNet.Internal
{
    class VolkDllModule
    {
        public VolkDllModule(params string[] searchNames)
        {
            this.searchNames = searchNames;
        }

        private string[] searchNames;
        private IntPtr module;

        private void EnsureModule()
        {
            if (module != IntPtr.Zero)
                return;
            foreach (var name in searchNames)
            {
                if (VolkPlatformNative.TryLoadLibrary(name, out module))
                    return;
            }
            throw new DllNotFoundException("Unable to find VOLK library!");
        }

        private IntPtr GetMethod(string name)
        {
            EnsureModule();
            if (VolkPlatformNative.TryGetProcAddress(module, name, out IntPtr result))
                return result;
            else
                throw new EntryPointNotFoundException($"This VOLK version is unsupported. Could not find method \"{name}\".");
        }

        private unsafe IntPtr GetResolvedMethodPointer(string name)
        {
            return ((IntPtr*)GetMethod(name))[0];
        }

        public T GetMethod<T>(string name) where T : Delegate
        {
            return GetDelegateForFunctionPointer<T>(GetMethod(name));
        }

        public T GetResolvedMethodPointer<T>(string name) where T : Delegate
        {
            return GetDelegateForFunctionPointer<T>(GetResolvedMethodPointer(name));
        }

        private static T GetDelegateForFunctionPointer<T>(IntPtr method) where T : Delegate
        {
            return (T)Marshal.GetDelegateForFunctionPointer(method, typeof(T));
        }
    }
}
