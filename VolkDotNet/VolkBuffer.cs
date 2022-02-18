using System;
using System.Runtime.InteropServices;

namespace VolkDotNet
{
    public unsafe class VolkBuffer<T> : IDisposable where T : unmanaged
    {
        public VolkBuffer(long count)
        {
            this.count = count;
            ptr = VolkFunctions.volk_malloc((IntPtr)Size, Alignment);
            if (ptr == IntPtr.Zero)
                throw new Exception("Failed to allocate memory using volk_malloc!");
        }

        ~VolkBuffer()
        {
            Dispose();
        }

        private long count;
        private IntPtr ptr;

        public static IntPtr Alignment => VolkFunctions.volk_get_alignment();

        public long Count => count;
        public long Size => count * sizeof(T);
        public IntPtr Pointer
        {
            get
            {
                if (ptr == IntPtr.Zero)
                    throw new ObjectDisposedException(GetType().Name);
                return ptr;
            }
        }

        public void Dispose()
        {
            if (ptr != IntPtr.Zero)
            {
                VolkFunctions.volk_free(ptr);
                ptr = IntPtr.Zero;
            }
        }

        public static implicit operator T*(VolkBuffer<T> ctx)
        {
            return (T*)ctx.Pointer;
        }
    }
}
