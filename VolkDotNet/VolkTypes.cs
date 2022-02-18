using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace VolkDotNet
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VolkComplexByte
    {
        public byte real;
        public byte imag;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VolkComplexShort
    {
        public short real;
        public short imag;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VolkComplexInt
    {
        public int real;
        public int imag;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VolkComplexLong
    {
        public long real;
        public long imag;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VolkComplexFloat
    {
        public float real;
        public float imag;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VolkComplexDouble
    {
        public double real;
        public double imag;
    }
}
