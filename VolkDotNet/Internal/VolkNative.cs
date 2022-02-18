using System;
using System.Collections.Generic;
using System.Text;

namespace VolkDotNet.Internal
{
    class VolkNative
    {
        internal static VolkDllModule volk = new VolkDllModule("volk", "libvolk");
    }
}
