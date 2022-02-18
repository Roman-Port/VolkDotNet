using System;
using VolkDotNet.Internal;

namespace VolkDotNet
{
    public unsafe class VolkFunctions
    {
        public static VolkDelegates.__d_volk_get_alignment volk_get_alignment = VolkNative.volk.GetMethod<VolkDelegates.__d_volk_get_alignment>("volk_get_alignment");
        public static VolkDelegates.__d_volk_malloc volk_malloc = VolkNative.volk.GetMethod<VolkDelegates.__d_volk_malloc>("volk_malloc");
        public static VolkDelegates.__d_volk_free volk_free = VolkNative.volk.GetMethod<VolkDelegates.__d_volk_free>("volk_free");
    }
}
