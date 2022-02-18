using System;

namespace VolkDotNet.Tests
{
    class Program
    {
        static unsafe void Main(string[] args)
        {
            VolkComplexFloat phase = new VolkComplexFloat
            {
                real = 0,
                imag = 0
            };
            VolkComplexFloat phaseInc = new VolkComplexFloat
            {
                real = MathF.Cos(0.01f),
                imag = MathF.Sin(0.1f)
            };
            using (VolkBuffer<VolkComplexFloat> buffer = new VolkBuffer<VolkComplexFloat>(1000))
            {
                for (int i = 0; i < 10000; i++)
                    VolkKernels.volk_32fc_s32fc_x2_rotator_32fc(buffer, buffer, phaseInc, &phase, (int)buffer.Count);
            }
        }
    }
}
