using System;
using System.Collections.Generic;
using System.Text;

namespace VolkDotNetGenerator
{
    class CSharpTypeConverter
    {
        public static string ConvertToCSharp(string type)
        {
            //Do replacements
            if (type == "char")
                type = "byte";
            if (type == "uint8_t")
                type = "byte";
            if (type == "int8_t")
                type = "sbyte";
            if (type == "uint16_t")
                type = "ushort";
            if (type == "int16_t")
                type = "short";
            if (type == "uint32_t")
                type = "uint";
            if (type == "int32_t")
                type = "int";
            if (type == "uint64_t")
                type = "ulong";
            if (type == "int64_t")
                type = "long";
            if (type == "lv_8sc_t")
                type = "VolkComplexByte";
            if (type == "lv_16sc_t")
                type = "VolkComplexShort";
            if (type == "lv_32sc_t")
                type = "VolkComplexInt";
            if (type == "lv_64sc_t")
                type = "VolkComplexLong";
            if (type == "lv_32fc_t")
                type = "VolkComplexFloat";
            if (type == "lv_64fc_t")
                type = "VolkComplexDouble";

            return type;
        }
    }
}
