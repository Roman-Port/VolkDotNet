using System;
using VolkDotNet.Internal;

namespace VolkDotNet
{
    public unsafe class VolkKernels
    {
        private const string _EP_VOLK_16I_32FC_DOT_PROD_32FC = "volk_16i_32fc_dot_prod_32fc";
        public static VolkDelegates.__d_volk_16i_32fc_dot_prod_32fc volk_16i_32fc_dot_prod_32fc = (VolkComplexFloat* result, short* input, VolkComplexFloat* taps, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_16i_32fc_dot_prod_32fc>(_EP_VOLK_16I_32FC_DOT_PROD_32FC)(result, input, taps, num_points);
            volk_16i_32fc_dot_prod_32fc = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_16i_32fc_dot_prod_32fc>(_EP_VOLK_16I_32FC_DOT_PROD_32FC);
        };
        private const string _EP_VOLK_16I_BRANCH_4_STATE_8 = "volk_16i_branch_4_state_8";
        public static VolkDelegates.__d_volk_16i_branch_4_state_8 volk_16i_branch_4_state_8 = (short* target, short* src0, byte** permuters, short* cntl2, short* cntl3, short* scalars) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_16i_branch_4_state_8>(_EP_VOLK_16I_BRANCH_4_STATE_8)(target, src0, permuters, cntl2, cntl3, scalars);
            volk_16i_branch_4_state_8 = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_16i_branch_4_state_8>(_EP_VOLK_16I_BRANCH_4_STATE_8);
        };
        private const string _EP_VOLK_16I_CONVERT_8I = "volk_16i_convert_8i";
        public static VolkDelegates.__d_volk_16i_convert_8i volk_16i_convert_8i = (sbyte* outputVector, short* inputVector, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_16i_convert_8i>(_EP_VOLK_16I_CONVERT_8I)(outputVector, inputVector, num_points);
            volk_16i_convert_8i = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_16i_convert_8i>(_EP_VOLK_16I_CONVERT_8I);
        };
        private const string _EP_VOLK_16I_MAX_STAR_16I = "volk_16i_max_star_16i";
        public static VolkDelegates.__d_volk_16i_max_star_16i volk_16i_max_star_16i = (short* target, short* src0, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_16i_max_star_16i>(_EP_VOLK_16I_MAX_STAR_16I)(target, src0, num_points);
            volk_16i_max_star_16i = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_16i_max_star_16i>(_EP_VOLK_16I_MAX_STAR_16I);
        };
        private const string _EP_VOLK_16I_MAX_STAR_HORIZONTAL_16I = "volk_16i_max_star_horizontal_16i";
        public static VolkDelegates.__d_volk_16i_max_star_horizontal_16i volk_16i_max_star_horizontal_16i = (short* target, short* src0, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_16i_max_star_horizontal_16i>(_EP_VOLK_16I_MAX_STAR_HORIZONTAL_16I)(target, src0, num_points);
            volk_16i_max_star_horizontal_16i = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_16i_max_star_horizontal_16i>(_EP_VOLK_16I_MAX_STAR_HORIZONTAL_16I);
        };
        private const string _EP_VOLK_16I_PERMUTE_AND_SCALAR_ADD = "volk_16i_permute_and_scalar_add";
        public static VolkDelegates.__d_volk_16i_permute_and_scalar_add volk_16i_permute_and_scalar_add = (short* target, short* src0, short* permute_indexes, short* cntl0, short* cntl1, short* cntl2, short* cntl3, short* scalars, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_16i_permute_and_scalar_add>(_EP_VOLK_16I_PERMUTE_AND_SCALAR_ADD)(target, src0, permute_indexes, cntl0, cntl1, cntl2, cntl3, scalars, num_points);
            volk_16i_permute_and_scalar_add = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_16i_permute_and_scalar_add>(_EP_VOLK_16I_PERMUTE_AND_SCALAR_ADD);
        };
        private const string _EP_VOLK_16I_S32F_CONVERT_32F = "volk_16i_s32f_convert_32f";
        public static VolkDelegates.__d_volk_16i_s32f_convert_32f volk_16i_s32f_convert_32f = (float* outputVector, short* inputVector, float scalar, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_16i_s32f_convert_32f>(_EP_VOLK_16I_S32F_CONVERT_32F)(outputVector, inputVector, scalar, num_points);
            volk_16i_s32f_convert_32f = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_16i_s32f_convert_32f>(_EP_VOLK_16I_S32F_CONVERT_32F);
        };
        private const string _EP_VOLK_16I_X4_QUAD_MAX_STAR_16I = "volk_16i_x4_quad_max_star_16i";
        public static VolkDelegates.__d_volk_16i_x4_quad_max_star_16i volk_16i_x4_quad_max_star_16i = (short* target, short* src0, short* src1, short* src2, short* src3, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_16i_x4_quad_max_star_16i>(_EP_VOLK_16I_X4_QUAD_MAX_STAR_16I)(target, src0, src1, src2, src3, num_points);
            volk_16i_x4_quad_max_star_16i = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_16i_x4_quad_max_star_16i>(_EP_VOLK_16I_X4_QUAD_MAX_STAR_16I);
        };
        private const string _EP_VOLK_16I_X5_ADD_QUAD_16I_X4 = "volk_16i_x5_add_quad_16i_x4";
        public static VolkDelegates.__d_volk_16i_x5_add_quad_16i_x4 volk_16i_x5_add_quad_16i_x4 = (short* target0, short* target1, short* target2, short* target3, short* src0, short* src1, short* src2, short* src3, short* src4, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_16i_x5_add_quad_16i_x4>(_EP_VOLK_16I_X5_ADD_QUAD_16I_X4)(target0, target1, target2, target3, src0, src1, src2, src3, src4, num_points);
            volk_16i_x5_add_quad_16i_x4 = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_16i_x5_add_quad_16i_x4>(_EP_VOLK_16I_X5_ADD_QUAD_16I_X4);
        };
        private const string _EP_VOLK_16IC_CONVERT_32FC = "volk_16ic_convert_32fc";
        public static VolkDelegates.__d_volk_16ic_convert_32fc volk_16ic_convert_32fc = (VolkComplexFloat* outputVector, VolkComplexShort* inputVector, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_16ic_convert_32fc>(_EP_VOLK_16IC_CONVERT_32FC)(outputVector, inputVector, num_points);
            volk_16ic_convert_32fc = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_16ic_convert_32fc>(_EP_VOLK_16IC_CONVERT_32FC);
        };
        private const string _EP_VOLK_16IC_DEINTERLEAVE_16I_X2 = "volk_16ic_deinterleave_16i_x2";
        public static VolkDelegates.__d_volk_16ic_deinterleave_16i_x2 volk_16ic_deinterleave_16i_x2 = (short* iBuffer, short* qBuffer, VolkComplexShort* complexVector, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_16ic_deinterleave_16i_x2>(_EP_VOLK_16IC_DEINTERLEAVE_16I_X2)(iBuffer, qBuffer, complexVector, num_points);
            volk_16ic_deinterleave_16i_x2 = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_16ic_deinterleave_16i_x2>(_EP_VOLK_16IC_DEINTERLEAVE_16I_X2);
        };
        private const string _EP_VOLK_16IC_DEINTERLEAVE_REAL_16I = "volk_16ic_deinterleave_real_16i";
        public static VolkDelegates.__d_volk_16ic_deinterleave_real_16i volk_16ic_deinterleave_real_16i = (short* iBuffer, VolkComplexShort* complexVector, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_16ic_deinterleave_real_16i>(_EP_VOLK_16IC_DEINTERLEAVE_REAL_16I)(iBuffer, complexVector, num_points);
            volk_16ic_deinterleave_real_16i = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_16ic_deinterleave_real_16i>(_EP_VOLK_16IC_DEINTERLEAVE_REAL_16I);
        };
        private const string _EP_VOLK_16IC_DEINTERLEAVE_REAL_8I = "volk_16ic_deinterleave_real_8i";
        public static VolkDelegates.__d_volk_16ic_deinterleave_real_8i volk_16ic_deinterleave_real_8i = (sbyte* iBuffer, VolkComplexShort* complexVector, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_16ic_deinterleave_real_8i>(_EP_VOLK_16IC_DEINTERLEAVE_REAL_8I)(iBuffer, complexVector, num_points);
            volk_16ic_deinterleave_real_8i = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_16ic_deinterleave_real_8i>(_EP_VOLK_16IC_DEINTERLEAVE_REAL_8I);
        };
        private const string _EP_VOLK_16IC_MAGNITUDE_16I = "volk_16ic_magnitude_16i";
        public static VolkDelegates.__d_volk_16ic_magnitude_16i volk_16ic_magnitude_16i = (short* magnitudeVector, VolkComplexShort* complexVector, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_16ic_magnitude_16i>(_EP_VOLK_16IC_MAGNITUDE_16I)(magnitudeVector, complexVector, num_points);
            volk_16ic_magnitude_16i = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_16ic_magnitude_16i>(_EP_VOLK_16IC_MAGNITUDE_16I);
        };
        private const string _EP_VOLK_16IC_S32F_DEINTERLEAVE_32F_X2 = "volk_16ic_s32f_deinterleave_32f_x2";
        public static VolkDelegates.__d_volk_16ic_s32f_deinterleave_32f_x2 volk_16ic_s32f_deinterleave_32f_x2 = (float* iBuffer, float* qBuffer, VolkComplexShort* complexVector, float scalar, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_16ic_s32f_deinterleave_32f_x2>(_EP_VOLK_16IC_S32F_DEINTERLEAVE_32F_X2)(iBuffer, qBuffer, complexVector, scalar, num_points);
            volk_16ic_s32f_deinterleave_32f_x2 = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_16ic_s32f_deinterleave_32f_x2>(_EP_VOLK_16IC_S32F_DEINTERLEAVE_32F_X2);
        };
        private const string _EP_VOLK_16IC_S32F_DEINTERLEAVE_REAL_32F = "volk_16ic_s32f_deinterleave_real_32f";
        public static VolkDelegates.__d_volk_16ic_s32f_deinterleave_real_32f volk_16ic_s32f_deinterleave_real_32f = (float* iBuffer, VolkComplexShort* complexVector, float scalar, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_16ic_s32f_deinterleave_real_32f>(_EP_VOLK_16IC_S32F_DEINTERLEAVE_REAL_32F)(iBuffer, complexVector, scalar, num_points);
            volk_16ic_s32f_deinterleave_real_32f = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_16ic_s32f_deinterleave_real_32f>(_EP_VOLK_16IC_S32F_DEINTERLEAVE_REAL_32F);
        };
        private const string _EP_VOLK_16IC_S32F_MAGNITUDE_32F = "volk_16ic_s32f_magnitude_32f";
        public static VolkDelegates.__d_volk_16ic_s32f_magnitude_32f volk_16ic_s32f_magnitude_32f = (float* magnitudeVector, VolkComplexShort* complexVector, float scalar, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_16ic_s32f_magnitude_32f>(_EP_VOLK_16IC_S32F_MAGNITUDE_32F)(magnitudeVector, complexVector, scalar, num_points);
            volk_16ic_s32f_magnitude_32f = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_16ic_s32f_magnitude_32f>(_EP_VOLK_16IC_S32F_MAGNITUDE_32F);
        };
        private const string _EP_VOLK_16IC_X2_DOT_PROD_16IC = "volk_16ic_x2_dot_prod_16ic";
        public static VolkDelegates.__d_volk_16ic_x2_dot_prod_16ic volk_16ic_x2_dot_prod_16ic = (VolkComplexShort* result, VolkComplexShort* in_a, VolkComplexShort* in_b, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_16ic_x2_dot_prod_16ic>(_EP_VOLK_16IC_X2_DOT_PROD_16IC)(result, in_a, in_b, num_points);
            volk_16ic_x2_dot_prod_16ic = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_16ic_x2_dot_prod_16ic>(_EP_VOLK_16IC_X2_DOT_PROD_16IC);
        };
        private const string _EP_VOLK_16IC_X2_MULTIPLY_16IC = "volk_16ic_x2_multiply_16ic";
        public static VolkDelegates.__d_volk_16ic_x2_multiply_16ic volk_16ic_x2_multiply_16ic = (VolkComplexShort* result, VolkComplexShort* in_a, VolkComplexShort* in_b, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_16ic_x2_multiply_16ic>(_EP_VOLK_16IC_X2_MULTIPLY_16IC)(result, in_a, in_b, num_points);
            volk_16ic_x2_multiply_16ic = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_16ic_x2_multiply_16ic>(_EP_VOLK_16IC_X2_MULTIPLY_16IC);
        };
        private const string _EP_VOLK_16U_BYTESWAP = "volk_16u_byteswap";
        public static VolkDelegates.__d_volk_16u_byteswap volk_16u_byteswap = (ushort* intsToSwap, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_16u_byteswap>(_EP_VOLK_16U_BYTESWAP)(intsToSwap, num_points);
            volk_16u_byteswap = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_16u_byteswap>(_EP_VOLK_16U_BYTESWAP);
        };
        private const string _EP_VOLK_16U_BYTESWAPPUPPET_16U = "volk_16u_byteswappuppet_16u";
        public static VolkDelegates.__d_volk_16u_byteswappuppet_16u volk_16u_byteswappuppet_16u = (ushort* output, ushort* intsToSwap, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_16u_byteswappuppet_16u>(_EP_VOLK_16U_BYTESWAPPUPPET_16U)(output, intsToSwap, num_points);
            volk_16u_byteswappuppet_16u = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_16u_byteswappuppet_16u>(_EP_VOLK_16U_BYTESWAPPUPPET_16U);
        };
        private const string _EP_VOLK_32F_64F_ADD_64F = "volk_32f_64f_add_64f";
        public static VolkDelegates.__d_volk_32f_64f_add_64f volk_32f_64f_add_64f = (double* cVector, float* aVector, double* bVector, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_64f_add_64f>(_EP_VOLK_32F_64F_ADD_64F)(cVector, aVector, bVector, num_points);
            volk_32f_64f_add_64f = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_64f_add_64f>(_EP_VOLK_32F_64F_ADD_64F);
        };
        private const string _EP_VOLK_32F_64F_MULTIPLY_64F = "volk_32f_64f_multiply_64f";
        public static VolkDelegates.__d_volk_32f_64f_multiply_64f volk_32f_64f_multiply_64f = (double* cVector, float* aVector, double* bVector, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_64f_multiply_64f>(_EP_VOLK_32F_64F_MULTIPLY_64F)(cVector, aVector, bVector, num_points);
            volk_32f_64f_multiply_64f = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_64f_multiply_64f>(_EP_VOLK_32F_64F_MULTIPLY_64F);
        };
        private const string _EP_VOLK_32F_8U_POLARBUTTERFLY_32F = "volk_32f_8u_polarbutterfly_32f";
        public static VolkDelegates.__d_volk_32f_8u_polarbutterfly_32f volk_32f_8u_polarbutterfly_32f = (float* llrs, byte* u, int frame_exp, int stage, int u_num, int row) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_8u_polarbutterfly_32f>(_EP_VOLK_32F_8U_POLARBUTTERFLY_32F)(llrs, u, frame_exp, stage, u_num, row);
            volk_32f_8u_polarbutterfly_32f = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_8u_polarbutterfly_32f>(_EP_VOLK_32F_8U_POLARBUTTERFLY_32F);
        };
        private const string _EP_VOLK_32F_8U_POLARBUTTERFLYPUPPET_32F = "volk_32f_8u_polarbutterflypuppet_32f";
        public static VolkDelegates.__d_volk_32f_8u_polarbutterflypuppet_32f volk_32f_8u_polarbutterflypuppet_32f = (float* llrs, float* input, byte* u, int elements) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_8u_polarbutterflypuppet_32f>(_EP_VOLK_32F_8U_POLARBUTTERFLYPUPPET_32F)(llrs, input, u, elements);
            volk_32f_8u_polarbutterflypuppet_32f = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_8u_polarbutterflypuppet_32f>(_EP_VOLK_32F_8U_POLARBUTTERFLYPUPPET_32F);
        };
        private const string _EP_VOLK_32F_ACCUMULATOR_S32F = "volk_32f_accumulator_s32f";
        public static VolkDelegates.__d_volk_32f_accumulator_s32f volk_32f_accumulator_s32f = (float* result, float* inputBuffer, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_accumulator_s32f>(_EP_VOLK_32F_ACCUMULATOR_S32F)(result, inputBuffer, num_points);
            volk_32f_accumulator_s32f = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_accumulator_s32f>(_EP_VOLK_32F_ACCUMULATOR_S32F);
        };
        private const string _EP_VOLK_32F_ACOS_32F = "volk_32f_acos_32f";
        public static VolkDelegates.__d_volk_32f_acos_32f volk_32f_acos_32f = (float* bVector, float* aVector, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_acos_32f>(_EP_VOLK_32F_ACOS_32F)(bVector, aVector, num_points);
            volk_32f_acos_32f = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_acos_32f>(_EP_VOLK_32F_ACOS_32F);
        };
        private const string _EP_VOLK_32F_ASIN_32F = "volk_32f_asin_32f";
        public static VolkDelegates.__d_volk_32f_asin_32f volk_32f_asin_32f = (float* bVector, float* aVector, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_asin_32f>(_EP_VOLK_32F_ASIN_32F)(bVector, aVector, num_points);
            volk_32f_asin_32f = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_asin_32f>(_EP_VOLK_32F_ASIN_32F);
        };
        private const string _EP_VOLK_32F_ATAN_32F = "volk_32f_atan_32f";
        public static VolkDelegates.__d_volk_32f_atan_32f volk_32f_atan_32f = (float* bVector, float* aVector, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_atan_32f>(_EP_VOLK_32F_ATAN_32F)(bVector, aVector, num_points);
            volk_32f_atan_32f = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_atan_32f>(_EP_VOLK_32F_ATAN_32F);
        };
        private const string _EP_VOLK_32F_BINARY_SLICER_32I = "volk_32f_binary_slicer_32i";
        public static VolkDelegates.__d_volk_32f_binary_slicer_32i volk_32f_binary_slicer_32i = (int* cVector, float* aVector, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_binary_slicer_32i>(_EP_VOLK_32F_BINARY_SLICER_32I)(cVector, aVector, num_points);
            volk_32f_binary_slicer_32i = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_binary_slicer_32i>(_EP_VOLK_32F_BINARY_SLICER_32I);
        };
        private const string _EP_VOLK_32F_BINARY_SLICER_8I = "volk_32f_binary_slicer_8i";
        public static VolkDelegates.__d_volk_32f_binary_slicer_8i volk_32f_binary_slicer_8i = (sbyte* cVector, float* aVector, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_binary_slicer_8i>(_EP_VOLK_32F_BINARY_SLICER_8I)(cVector, aVector, num_points);
            volk_32f_binary_slicer_8i = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_binary_slicer_8i>(_EP_VOLK_32F_BINARY_SLICER_8I);
        };
        private const string _EP_VOLK_32F_CONVERT_64F = "volk_32f_convert_64f";
        public static VolkDelegates.__d_volk_32f_convert_64f volk_32f_convert_64f = (double* outputVector, float* inputVector, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_convert_64f>(_EP_VOLK_32F_CONVERT_64F)(outputVector, inputVector, num_points);
            volk_32f_convert_64f = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_convert_64f>(_EP_VOLK_32F_CONVERT_64F);
        };
        private const string _EP_VOLK_32F_COS_32F = "volk_32f_cos_32f";
        public static VolkDelegates.__d_volk_32f_cos_32f volk_32f_cos_32f = (float* cosVector, float* inVector, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_cos_32f>(_EP_VOLK_32F_COS_32F)(cosVector, inVector, num_points);
            volk_32f_cos_32f = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_cos_32f>(_EP_VOLK_32F_COS_32F);
        };
        private const string _EP_VOLK_32F_EXP_32F = "volk_32f_exp_32f";
        public static VolkDelegates.__d_volk_32f_exp_32f volk_32f_exp_32f = (float* bVector, float* aVector, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_exp_32f>(_EP_VOLK_32F_EXP_32F)(bVector, aVector, num_points);
            volk_32f_exp_32f = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_exp_32f>(_EP_VOLK_32F_EXP_32F);
        };
        private const string _EP_VOLK_32F_EXPFAST_32F = "volk_32f_expfast_32f";
        public static VolkDelegates.__d_volk_32f_expfast_32f volk_32f_expfast_32f = (float* bVector, float* aVector, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_expfast_32f>(_EP_VOLK_32F_EXPFAST_32F)(bVector, aVector, num_points);
            volk_32f_expfast_32f = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_expfast_32f>(_EP_VOLK_32F_EXPFAST_32F);
        };
        private const string _EP_VOLK_32F_INDEX_MAX_16U = "volk_32f_index_max_16u";
        public static VolkDelegates.__d_volk_32f_index_max_16u volk_32f_index_max_16u = (ushort* target, float* src0, uint num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_index_max_16u>(_EP_VOLK_32F_INDEX_MAX_16U)(target, src0, num_points);
            volk_32f_index_max_16u = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_index_max_16u>(_EP_VOLK_32F_INDEX_MAX_16U);
        };
        private const string _EP_VOLK_32F_INDEX_MAX_32U = "volk_32f_index_max_32u";
        public static VolkDelegates.__d_volk_32f_index_max_32u volk_32f_index_max_32u = (uint* target, float* src0, uint num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_index_max_32u>(_EP_VOLK_32F_INDEX_MAX_32U)(target, src0, num_points);
            volk_32f_index_max_32u = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_index_max_32u>(_EP_VOLK_32F_INDEX_MAX_32U);
        };
        private const string _EP_VOLK_32F_INVSQRT_32F = "volk_32f_invsqrt_32f";
        public static VolkDelegates.__d_volk_32f_invsqrt_32f volk_32f_invsqrt_32f = (float* cVector, float* aVector, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_invsqrt_32f>(_EP_VOLK_32F_INVSQRT_32F)(cVector, aVector, num_points);
            volk_32f_invsqrt_32f = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_invsqrt_32f>(_EP_VOLK_32F_INVSQRT_32F);
        };
        private const string _EP_VOLK_32F_LOG2_32F = "volk_32f_log2_32f";
        public static VolkDelegates.__d_volk_32f_log2_32f volk_32f_log2_32f = (float* bVector, float* aVector, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_log2_32f>(_EP_VOLK_32F_LOG2_32F)(bVector, aVector, num_points);
            volk_32f_log2_32f = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_log2_32f>(_EP_VOLK_32F_LOG2_32F);
        };
        private const string _EP_VOLK_32F_NULL_32F = "volk_32f_null_32f";
        public static VolkDelegates.__d_volk_32f_null_32f volk_32f_null_32f = (float* bVector, float* aVector, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_null_32f>(_EP_VOLK_32F_NULL_32F)(bVector, aVector, num_points);
            volk_32f_null_32f = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_null_32f>(_EP_VOLK_32F_NULL_32F);
        };
        private const string _EP_VOLK_32F_S32F_32F_FM_DETECT_32F = "volk_32f_s32f_32f_fm_detect_32f";
        public static VolkDelegates.__d_volk_32f_s32f_32f_fm_detect_32f volk_32f_s32f_32f_fm_detect_32f = (float* outputVector, float* inputVector, float bound, float* saveValue, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_s32f_32f_fm_detect_32f>(_EP_VOLK_32F_S32F_32F_FM_DETECT_32F)(outputVector, inputVector, bound, saveValue, num_points);
            volk_32f_s32f_32f_fm_detect_32f = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_s32f_32f_fm_detect_32f>(_EP_VOLK_32F_S32F_32F_FM_DETECT_32F);
        };
        private const string _EP_VOLK_32F_S32F_ADD_32F = "volk_32f_s32f_add_32f";
        public static VolkDelegates.__d_volk_32f_s32f_add_32f volk_32f_s32f_add_32f = (float* cVector, float* aVector, float scalar, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_s32f_add_32f>(_EP_VOLK_32F_S32F_ADD_32F)(cVector, aVector, scalar, num_points);
            volk_32f_s32f_add_32f = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_s32f_add_32f>(_EP_VOLK_32F_S32F_ADD_32F);
        };
        private const string _EP_VOLK_32F_S32F_CALC_SPECTRAL_NOISE_FLOOR_32F = "volk_32f_s32f_calc_spectral_noise_floor_32f";
        public static VolkDelegates.__d_volk_32f_s32f_calc_spectral_noise_floor_32f volk_32f_s32f_calc_spectral_noise_floor_32f = (float* noiseFloorAmplitude, float* realDataPoints, float spectralExclusionValue, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_s32f_calc_spectral_noise_floor_32f>(_EP_VOLK_32F_S32F_CALC_SPECTRAL_NOISE_FLOOR_32F)(noiseFloorAmplitude, realDataPoints, spectralExclusionValue, num_points);
            volk_32f_s32f_calc_spectral_noise_floor_32f = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_s32f_calc_spectral_noise_floor_32f>(_EP_VOLK_32F_S32F_CALC_SPECTRAL_NOISE_FLOOR_32F);
        };
        private const string _EP_VOLK_32F_S32F_CONVERT_16I = "volk_32f_s32f_convert_16i";
        public static VolkDelegates.__d_volk_32f_s32f_convert_16i volk_32f_s32f_convert_16i = (short* outputVector, float* inputVector, float scalar, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_s32f_convert_16i>(_EP_VOLK_32F_S32F_CONVERT_16I)(outputVector, inputVector, scalar, num_points);
            volk_32f_s32f_convert_16i = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_s32f_convert_16i>(_EP_VOLK_32F_S32F_CONVERT_16I);
        };
        private const string _EP_VOLK_32F_S32F_CONVERT_32I = "volk_32f_s32f_convert_32i";
        public static VolkDelegates.__d_volk_32f_s32f_convert_32i volk_32f_s32f_convert_32i = (int* outputVector, float* inputVector, float scalar, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_s32f_convert_32i>(_EP_VOLK_32F_S32F_CONVERT_32I)(outputVector, inputVector, scalar, num_points);
            volk_32f_s32f_convert_32i = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_s32f_convert_32i>(_EP_VOLK_32F_S32F_CONVERT_32I);
        };
        private const string _EP_VOLK_32F_S32F_CONVERT_8I = "volk_32f_s32f_convert_8i";
        public static VolkDelegates.__d_volk_32f_s32f_convert_8i volk_32f_s32f_convert_8i = (sbyte* outputVector, float* inputVector, float scalar, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_s32f_convert_8i>(_EP_VOLK_32F_S32F_CONVERT_8I)(outputVector, inputVector, scalar, num_points);
            volk_32f_s32f_convert_8i = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_s32f_convert_8i>(_EP_VOLK_32F_S32F_CONVERT_8I);
        };
        private const string _EP_VOLK_32F_S32F_MOD_RANGEPUPPET_32F = "volk_32f_s32f_mod_rangepuppet_32f";
        public static VolkDelegates.__d_volk_32f_s32f_mod_rangepuppet_32f volk_32f_s32f_mod_rangepuppet_32f = (float* output, float* input, float bound, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_s32f_mod_rangepuppet_32f>(_EP_VOLK_32F_S32F_MOD_RANGEPUPPET_32F)(output, input, bound, num_points);
            volk_32f_s32f_mod_rangepuppet_32f = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_s32f_mod_rangepuppet_32f>(_EP_VOLK_32F_S32F_MOD_RANGEPUPPET_32F);
        };
        private const string _EP_VOLK_32F_S32F_MULTIPLY_32F = "volk_32f_s32f_multiply_32f";
        public static VolkDelegates.__d_volk_32f_s32f_multiply_32f volk_32f_s32f_multiply_32f = (float* cVector, float* aVector, float scalar, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_s32f_multiply_32f>(_EP_VOLK_32F_S32F_MULTIPLY_32F)(cVector, aVector, scalar, num_points);
            volk_32f_s32f_multiply_32f = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_s32f_multiply_32f>(_EP_VOLK_32F_S32F_MULTIPLY_32F);
        };
        private const string _EP_VOLK_32F_S32F_NORMALIZE = "volk_32f_s32f_normalize";
        public static VolkDelegates.__d_volk_32f_s32f_normalize volk_32f_s32f_normalize = (float* vecBuffer, float scalar, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_s32f_normalize>(_EP_VOLK_32F_S32F_NORMALIZE)(vecBuffer, scalar, num_points);
            volk_32f_s32f_normalize = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_s32f_normalize>(_EP_VOLK_32F_S32F_NORMALIZE);
        };
        private const string _EP_VOLK_32F_S32F_POWER_32F = "volk_32f_s32f_power_32f";
        public static VolkDelegates.__d_volk_32f_s32f_power_32f volk_32f_s32f_power_32f = (float* cVector, float* aVector, float power, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_s32f_power_32f>(_EP_VOLK_32F_S32F_POWER_32F)(cVector, aVector, power, num_points);
            volk_32f_s32f_power_32f = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_s32f_power_32f>(_EP_VOLK_32F_S32F_POWER_32F);
        };
        private const string _EP_VOLK_32F_S32F_S32F_MOD_RANGE_32F = "volk_32f_s32f_s32f_mod_range_32f";
        public static VolkDelegates.__d_volk_32f_s32f_s32f_mod_range_32f volk_32f_s32f_s32f_mod_range_32f = (float* outputVector, float* inputVector, float lower_bound, float upper_bound, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_s32f_s32f_mod_range_32f>(_EP_VOLK_32F_S32F_S32F_MOD_RANGE_32F)(outputVector, inputVector, lower_bound, upper_bound, num_points);
            volk_32f_s32f_s32f_mod_range_32f = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_s32f_s32f_mod_range_32f>(_EP_VOLK_32F_S32F_S32F_MOD_RANGE_32F);
        };
        private const string _EP_VOLK_32F_S32F_STDDEV_32F = "volk_32f_s32f_stddev_32f";
        public static VolkDelegates.__d_volk_32f_s32f_stddev_32f volk_32f_s32f_stddev_32f = (float* stddev, float* inputBuffer, float mean, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_s32f_stddev_32f>(_EP_VOLK_32F_S32F_STDDEV_32F)(stddev, inputBuffer, mean, num_points);
            volk_32f_s32f_stddev_32f = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_s32f_stddev_32f>(_EP_VOLK_32F_S32F_STDDEV_32F);
        };
        private const string _EP_VOLK_32F_SIN_32F = "volk_32f_sin_32f";
        public static VolkDelegates.__d_volk_32f_sin_32f volk_32f_sin_32f = (float* sinVector, float* inVector, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_sin_32f>(_EP_VOLK_32F_SIN_32F)(sinVector, inVector, num_points);
            volk_32f_sin_32f = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_sin_32f>(_EP_VOLK_32F_SIN_32F);
        };
        private const string _EP_VOLK_32F_SQRT_32F = "volk_32f_sqrt_32f";
        public static VolkDelegates.__d_volk_32f_sqrt_32f volk_32f_sqrt_32f = (float* cVector, float* aVector, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_sqrt_32f>(_EP_VOLK_32F_SQRT_32F)(cVector, aVector, num_points);
            volk_32f_sqrt_32f = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_sqrt_32f>(_EP_VOLK_32F_SQRT_32F);
        };
        private const string _EP_VOLK_32F_STDDEV_AND_MEAN_32F_X2 = "volk_32f_stddev_and_mean_32f_x2";
        public static VolkDelegates.__d_volk_32f_stddev_and_mean_32f_x2 volk_32f_stddev_and_mean_32f_x2 = (float* stddev, float* mean, float* inputBuffer, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_stddev_and_mean_32f_x2>(_EP_VOLK_32F_STDDEV_AND_MEAN_32F_X2)(stddev, mean, inputBuffer, num_points);
            volk_32f_stddev_and_mean_32f_x2 = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_stddev_and_mean_32f_x2>(_EP_VOLK_32F_STDDEV_AND_MEAN_32F_X2);
        };
        private const string _EP_VOLK_32F_TAN_32F = "volk_32f_tan_32f";
        public static VolkDelegates.__d_volk_32f_tan_32f volk_32f_tan_32f = (float* bVector, float* aVector, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_tan_32f>(_EP_VOLK_32F_TAN_32F)(bVector, aVector, num_points);
            volk_32f_tan_32f = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_tan_32f>(_EP_VOLK_32F_TAN_32F);
        };
        private const string _EP_VOLK_32F_TANH_32F = "volk_32f_tanh_32f";
        public static VolkDelegates.__d_volk_32f_tanh_32f volk_32f_tanh_32f = (float* cVector, float* aVector, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_tanh_32f>(_EP_VOLK_32F_TANH_32F)(cVector, aVector, num_points);
            volk_32f_tanh_32f = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_tanh_32f>(_EP_VOLK_32F_TANH_32F);
        };
        private const string _EP_VOLK_32F_X2_ADD_32F = "volk_32f_x2_add_32f";
        public static VolkDelegates.__d_volk_32f_x2_add_32f volk_32f_x2_add_32f = (float* cVector, float* aVector, float* bVector, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_x2_add_32f>(_EP_VOLK_32F_X2_ADD_32F)(cVector, aVector, bVector, num_points);
            volk_32f_x2_add_32f = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_x2_add_32f>(_EP_VOLK_32F_X2_ADD_32F);
        };
        private const string _EP_VOLK_32F_X2_DIVIDE_32F = "volk_32f_x2_divide_32f";
        public static VolkDelegates.__d_volk_32f_x2_divide_32f volk_32f_x2_divide_32f = (float* cVector, float* aVector, float* bVector, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_x2_divide_32f>(_EP_VOLK_32F_X2_DIVIDE_32F)(cVector, aVector, bVector, num_points);
            volk_32f_x2_divide_32f = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_x2_divide_32f>(_EP_VOLK_32F_X2_DIVIDE_32F);
        };
        private const string _EP_VOLK_32F_X2_DOT_PROD_16I = "volk_32f_x2_dot_prod_16i";
        public static VolkDelegates.__d_volk_32f_x2_dot_prod_16i volk_32f_x2_dot_prod_16i = (short* result, float* input, float* taps, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_x2_dot_prod_16i>(_EP_VOLK_32F_X2_DOT_PROD_16I)(result, input, taps, num_points);
            volk_32f_x2_dot_prod_16i = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_x2_dot_prod_16i>(_EP_VOLK_32F_X2_DOT_PROD_16I);
        };
        private const string _EP_VOLK_32F_X2_DOT_PROD_32F = "volk_32f_x2_dot_prod_32f";
        public static VolkDelegates.__d_volk_32f_x2_dot_prod_32f volk_32f_x2_dot_prod_32f = (float* result, float* input, float* taps, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_x2_dot_prod_32f>(_EP_VOLK_32F_X2_DOT_PROD_32F)(result, input, taps, num_points);
            volk_32f_x2_dot_prod_32f = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_x2_dot_prod_32f>(_EP_VOLK_32F_X2_DOT_PROD_32F);
        };
        private const string _EP_VOLK_32F_X2_FM_DETECTPUPPET_32F = "volk_32f_x2_fm_detectpuppet_32f";
        public static VolkDelegates.__d_volk_32f_x2_fm_detectpuppet_32f volk_32f_x2_fm_detectpuppet_32f = (float* outputVector, float* inputVector, float* saveValue, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_x2_fm_detectpuppet_32f>(_EP_VOLK_32F_X2_FM_DETECTPUPPET_32F)(outputVector, inputVector, saveValue, num_points);
            volk_32f_x2_fm_detectpuppet_32f = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_x2_fm_detectpuppet_32f>(_EP_VOLK_32F_X2_FM_DETECTPUPPET_32F);
        };
        private const string _EP_VOLK_32F_X2_INTERLEAVE_32FC = "volk_32f_x2_interleave_32fc";
        public static VolkDelegates.__d_volk_32f_x2_interleave_32fc volk_32f_x2_interleave_32fc = (VolkComplexFloat* complexVector, float* iBuffer, float* qBuffer, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_x2_interleave_32fc>(_EP_VOLK_32F_X2_INTERLEAVE_32FC)(complexVector, iBuffer, qBuffer, num_points);
            volk_32f_x2_interleave_32fc = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_x2_interleave_32fc>(_EP_VOLK_32F_X2_INTERLEAVE_32FC);
        };
        private const string _EP_VOLK_32F_X2_MAX_32F = "volk_32f_x2_max_32f";
        public static VolkDelegates.__d_volk_32f_x2_max_32f volk_32f_x2_max_32f = (float* cVector, float* aVector, float* bVector, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_x2_max_32f>(_EP_VOLK_32F_X2_MAX_32F)(cVector, aVector, bVector, num_points);
            volk_32f_x2_max_32f = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_x2_max_32f>(_EP_VOLK_32F_X2_MAX_32F);
        };
        private const string _EP_VOLK_32F_X2_MIN_32F = "volk_32f_x2_min_32f";
        public static VolkDelegates.__d_volk_32f_x2_min_32f volk_32f_x2_min_32f = (float* cVector, float* aVector, float* bVector, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_x2_min_32f>(_EP_VOLK_32F_X2_MIN_32F)(cVector, aVector, bVector, num_points);
            volk_32f_x2_min_32f = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_x2_min_32f>(_EP_VOLK_32F_X2_MIN_32F);
        };
        private const string _EP_VOLK_32F_X2_MULTIPLY_32F = "volk_32f_x2_multiply_32f";
        public static VolkDelegates.__d_volk_32f_x2_multiply_32f volk_32f_x2_multiply_32f = (float* cVector, float* aVector, float* bVector, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_x2_multiply_32f>(_EP_VOLK_32F_X2_MULTIPLY_32F)(cVector, aVector, bVector, num_points);
            volk_32f_x2_multiply_32f = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_x2_multiply_32f>(_EP_VOLK_32F_X2_MULTIPLY_32F);
        };
        private const string _EP_VOLK_32F_X2_POW_32F = "volk_32f_x2_pow_32f";
        public static VolkDelegates.__d_volk_32f_x2_pow_32f volk_32f_x2_pow_32f = (float* cVector, float* bVector, float* aVector, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_x2_pow_32f>(_EP_VOLK_32F_X2_POW_32F)(cVector, bVector, aVector, num_points);
            volk_32f_x2_pow_32f = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_x2_pow_32f>(_EP_VOLK_32F_X2_POW_32F);
        };
        private const string _EP_VOLK_32F_X2_S32F_INTERLEAVE_16IC = "volk_32f_x2_s32f_interleave_16ic";
        public static VolkDelegates.__d_volk_32f_x2_s32f_interleave_16ic volk_32f_x2_s32f_interleave_16ic = (VolkComplexShort* complexVector, float* iBuffer, float* qBuffer, float scalar, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_x2_s32f_interleave_16ic>(_EP_VOLK_32F_X2_S32F_INTERLEAVE_16IC)(complexVector, iBuffer, qBuffer, scalar, num_points);
            volk_32f_x2_s32f_interleave_16ic = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_x2_s32f_interleave_16ic>(_EP_VOLK_32F_X2_S32F_INTERLEAVE_16IC);
        };
        private const string _EP_VOLK_32F_X2_SUBTRACT_32F = "volk_32f_x2_subtract_32f";
        public static VolkDelegates.__d_volk_32f_x2_subtract_32f volk_32f_x2_subtract_32f = (float* cVector, float* aVector, float* bVector, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_x2_subtract_32f>(_EP_VOLK_32F_X2_SUBTRACT_32F)(cVector, aVector, bVector, num_points);
            volk_32f_x2_subtract_32f = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_x2_subtract_32f>(_EP_VOLK_32F_X2_SUBTRACT_32F);
        };
        private const string _EP_VOLK_32F_X3_SUM_OF_POLY_32F = "volk_32f_x3_sum_of_poly_32f";
        public static VolkDelegates.__d_volk_32f_x3_sum_of_poly_32f volk_32f_x3_sum_of_poly_32f = (float* target, float* src0, float* center_point_array, float* cutoff, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_x3_sum_of_poly_32f>(_EP_VOLK_32F_X3_SUM_OF_POLY_32F)(target, src0, center_point_array, cutoff, num_points);
            volk_32f_x3_sum_of_poly_32f = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32f_x3_sum_of_poly_32f>(_EP_VOLK_32F_X3_SUM_OF_POLY_32F);
        };
        private const string _EP_VOLK_32FC_32F_ADD_32FC = "volk_32fc_32f_add_32fc";
        public static VolkDelegates.__d_volk_32fc_32f_add_32fc volk_32fc_32f_add_32fc = (VolkComplexFloat* cVector, VolkComplexFloat* aVector, float* bVector, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32fc_32f_add_32fc>(_EP_VOLK_32FC_32F_ADD_32FC)(cVector, aVector, bVector, num_points);
            volk_32fc_32f_add_32fc = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32fc_32f_add_32fc>(_EP_VOLK_32FC_32F_ADD_32FC);
        };
        private const string _EP_VOLK_32FC_32F_DOT_PROD_32FC = "volk_32fc_32f_dot_prod_32fc";
        public static VolkDelegates.__d_volk_32fc_32f_dot_prod_32fc volk_32fc_32f_dot_prod_32fc = (VolkComplexFloat* result, VolkComplexFloat* input, float* taps, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32fc_32f_dot_prod_32fc>(_EP_VOLK_32FC_32F_DOT_PROD_32FC)(result, input, taps, num_points);
            volk_32fc_32f_dot_prod_32fc = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32fc_32f_dot_prod_32fc>(_EP_VOLK_32FC_32F_DOT_PROD_32FC);
        };
        private const string _EP_VOLK_32FC_32F_MULTIPLY_32FC = "volk_32fc_32f_multiply_32fc";
        public static VolkDelegates.__d_volk_32fc_32f_multiply_32fc volk_32fc_32f_multiply_32fc = (VolkComplexFloat* cVector, VolkComplexFloat* aVector, float* bVector, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32fc_32f_multiply_32fc>(_EP_VOLK_32FC_32F_MULTIPLY_32FC)(cVector, aVector, bVector, num_points);
            volk_32fc_32f_multiply_32fc = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32fc_32f_multiply_32fc>(_EP_VOLK_32FC_32F_MULTIPLY_32FC);
        };
        private const string _EP_VOLK_32FC_ACCUMULATOR_S32FC = "volk_32fc_accumulator_s32fc";
        public static VolkDelegates.__d_volk_32fc_accumulator_s32fc volk_32fc_accumulator_s32fc = (VolkComplexFloat* result, VolkComplexFloat* inputBuffer, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32fc_accumulator_s32fc>(_EP_VOLK_32FC_ACCUMULATOR_S32FC)(result, inputBuffer, num_points);
            volk_32fc_accumulator_s32fc = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32fc_accumulator_s32fc>(_EP_VOLK_32FC_ACCUMULATOR_S32FC);
        };
        private const string _EP_VOLK_32FC_CONJUGATE_32FC = "volk_32fc_conjugate_32fc";
        public static VolkDelegates.__d_volk_32fc_conjugate_32fc volk_32fc_conjugate_32fc = (VolkComplexFloat* cVector, VolkComplexFloat* aVector, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32fc_conjugate_32fc>(_EP_VOLK_32FC_CONJUGATE_32FC)(cVector, aVector, num_points);
            volk_32fc_conjugate_32fc = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32fc_conjugate_32fc>(_EP_VOLK_32FC_CONJUGATE_32FC);
        };
        private const string _EP_VOLK_32FC_CONVERT_16IC = "volk_32fc_convert_16ic";
        public static VolkDelegates.__d_volk_32fc_convert_16ic volk_32fc_convert_16ic = (VolkComplexShort* outputVector, VolkComplexFloat* inputVector, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32fc_convert_16ic>(_EP_VOLK_32FC_CONVERT_16IC)(outputVector, inputVector, num_points);
            volk_32fc_convert_16ic = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32fc_convert_16ic>(_EP_VOLK_32FC_CONVERT_16IC);
        };
        private const string _EP_VOLK_32FC_DEINTERLEAVE_32F_X2 = "volk_32fc_deinterleave_32f_x2";
        public static VolkDelegates.__d_volk_32fc_deinterleave_32f_x2 volk_32fc_deinterleave_32f_x2 = (float* iBuffer, float* qBuffer, VolkComplexFloat* complexVector, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32fc_deinterleave_32f_x2>(_EP_VOLK_32FC_DEINTERLEAVE_32F_X2)(iBuffer, qBuffer, complexVector, num_points);
            volk_32fc_deinterleave_32f_x2 = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32fc_deinterleave_32f_x2>(_EP_VOLK_32FC_DEINTERLEAVE_32F_X2);
        };
        private const string _EP_VOLK_32FC_DEINTERLEAVE_64F_X2 = "volk_32fc_deinterleave_64f_x2";
        public static VolkDelegates.__d_volk_32fc_deinterleave_64f_x2 volk_32fc_deinterleave_64f_x2 = (double* iBuffer, double* qBuffer, VolkComplexFloat* complexVector, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32fc_deinterleave_64f_x2>(_EP_VOLK_32FC_DEINTERLEAVE_64F_X2)(iBuffer, qBuffer, complexVector, num_points);
            volk_32fc_deinterleave_64f_x2 = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32fc_deinterleave_64f_x2>(_EP_VOLK_32FC_DEINTERLEAVE_64F_X2);
        };
        private const string _EP_VOLK_32FC_DEINTERLEAVE_IMAG_32F = "volk_32fc_deinterleave_imag_32f";
        public static VolkDelegates.__d_volk_32fc_deinterleave_imag_32f volk_32fc_deinterleave_imag_32f = (float* qBuffer, VolkComplexFloat* complexVector, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32fc_deinterleave_imag_32f>(_EP_VOLK_32FC_DEINTERLEAVE_IMAG_32F)(qBuffer, complexVector, num_points);
            volk_32fc_deinterleave_imag_32f = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32fc_deinterleave_imag_32f>(_EP_VOLK_32FC_DEINTERLEAVE_IMAG_32F);
        };
        private const string _EP_VOLK_32FC_DEINTERLEAVE_REAL_32F = "volk_32fc_deinterleave_real_32f";
        public static VolkDelegates.__d_volk_32fc_deinterleave_real_32f volk_32fc_deinterleave_real_32f = (float* iBuffer, VolkComplexFloat* complexVector, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32fc_deinterleave_real_32f>(_EP_VOLK_32FC_DEINTERLEAVE_REAL_32F)(iBuffer, complexVector, num_points);
            volk_32fc_deinterleave_real_32f = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32fc_deinterleave_real_32f>(_EP_VOLK_32FC_DEINTERLEAVE_REAL_32F);
        };
        private const string _EP_VOLK_32FC_DEINTERLEAVE_REAL_64F = "volk_32fc_deinterleave_real_64f";
        public static VolkDelegates.__d_volk_32fc_deinterleave_real_64f volk_32fc_deinterleave_real_64f = (double* iBuffer, VolkComplexFloat* complexVector, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32fc_deinterleave_real_64f>(_EP_VOLK_32FC_DEINTERLEAVE_REAL_64F)(iBuffer, complexVector, num_points);
            volk_32fc_deinterleave_real_64f = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32fc_deinterleave_real_64f>(_EP_VOLK_32FC_DEINTERLEAVE_REAL_64F);
        };
        private const string _EP_VOLK_32FC_INDEX_MAX_16U = "volk_32fc_index_max_16u";
        public static VolkDelegates.__d_volk_32fc_index_max_16u volk_32fc_index_max_16u = (ushort* target, VolkComplexFloat* src0, uint num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32fc_index_max_16u>(_EP_VOLK_32FC_INDEX_MAX_16U)(target, src0, num_points);
            volk_32fc_index_max_16u = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32fc_index_max_16u>(_EP_VOLK_32FC_INDEX_MAX_16U);
        };
        private const string _EP_VOLK_32FC_INDEX_MAX_32U = "volk_32fc_index_max_32u";
        public static VolkDelegates.__d_volk_32fc_index_max_32u volk_32fc_index_max_32u = (uint* target, VolkComplexFloat* src0, uint num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32fc_index_max_32u>(_EP_VOLK_32FC_INDEX_MAX_32U)(target, src0, num_points);
            volk_32fc_index_max_32u = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32fc_index_max_32u>(_EP_VOLK_32FC_INDEX_MAX_32U);
        };
        private const string _EP_VOLK_32FC_MAGNITUDE_32F = "volk_32fc_magnitude_32f";
        public static VolkDelegates.__d_volk_32fc_magnitude_32f volk_32fc_magnitude_32f = (float* magnitudeVector, VolkComplexFloat* complexVector, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32fc_magnitude_32f>(_EP_VOLK_32FC_MAGNITUDE_32F)(magnitudeVector, complexVector, num_points);
            volk_32fc_magnitude_32f = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32fc_magnitude_32f>(_EP_VOLK_32FC_MAGNITUDE_32F);
        };
        private const string _EP_VOLK_32FC_MAGNITUDE_SQUARED_32F = "volk_32fc_magnitude_squared_32f";
        public static VolkDelegates.__d_volk_32fc_magnitude_squared_32f volk_32fc_magnitude_squared_32f = (float* magnitudeVector, VolkComplexFloat* complexVector, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32fc_magnitude_squared_32f>(_EP_VOLK_32FC_MAGNITUDE_SQUARED_32F)(magnitudeVector, complexVector, num_points);
            volk_32fc_magnitude_squared_32f = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32fc_magnitude_squared_32f>(_EP_VOLK_32FC_MAGNITUDE_SQUARED_32F);
        };
        private const string _EP_VOLK_32FC_S32F_ATAN2_32F = "volk_32fc_s32f_atan2_32f";
        public static VolkDelegates.__d_volk_32fc_s32f_atan2_32f volk_32fc_s32f_atan2_32f = (float* outputVector, VolkComplexFloat* complexVector, float normalizeFactor, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32fc_s32f_atan2_32f>(_EP_VOLK_32FC_S32F_ATAN2_32F)(outputVector, complexVector, normalizeFactor, num_points);
            volk_32fc_s32f_atan2_32f = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32fc_s32f_atan2_32f>(_EP_VOLK_32FC_S32F_ATAN2_32F);
        };
        private const string _EP_VOLK_32FC_S32F_DEINTERLEAVE_REAL_16I = "volk_32fc_s32f_deinterleave_real_16i";
        public static VolkDelegates.__d_volk_32fc_s32f_deinterleave_real_16i volk_32fc_s32f_deinterleave_real_16i = (short* iBuffer, VolkComplexFloat* complexVector, float scalar, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32fc_s32f_deinterleave_real_16i>(_EP_VOLK_32FC_S32F_DEINTERLEAVE_REAL_16I)(iBuffer, complexVector, scalar, num_points);
            volk_32fc_s32f_deinterleave_real_16i = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32fc_s32f_deinterleave_real_16i>(_EP_VOLK_32FC_S32F_DEINTERLEAVE_REAL_16I);
        };
        private const string _EP_VOLK_32FC_S32F_MAGNITUDE_16I = "volk_32fc_s32f_magnitude_16i";
        public static VolkDelegates.__d_volk_32fc_s32f_magnitude_16i volk_32fc_s32f_magnitude_16i = (short* magnitudeVector, VolkComplexFloat* complexVector, float scalar, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32fc_s32f_magnitude_16i>(_EP_VOLK_32FC_S32F_MAGNITUDE_16I)(magnitudeVector, complexVector, scalar, num_points);
            volk_32fc_s32f_magnitude_16i = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32fc_s32f_magnitude_16i>(_EP_VOLK_32FC_S32F_MAGNITUDE_16I);
        };
        private const string _EP_VOLK_32FC_S32F_POWER_32FC = "volk_32fc_s32f_power_32fc";
        public static VolkDelegates.__d_volk_32fc_s32f_power_32fc volk_32fc_s32f_power_32fc = (VolkComplexFloat* cVector, VolkComplexFloat* aVector, float power, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32fc_s32f_power_32fc>(_EP_VOLK_32FC_S32F_POWER_32FC)(cVector, aVector, power, num_points);
            volk_32fc_s32f_power_32fc = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32fc_s32f_power_32fc>(_EP_VOLK_32FC_S32F_POWER_32FC);
        };
        private const string _EP_VOLK_32FC_S32F_POWER_SPECTRAL_DENSITYPUPPET_32F = "volk_32fc_s32f_power_spectral_densitypuppet_32f";
        public static VolkDelegates.__d_volk_32fc_s32f_power_spectral_densitypuppet_32f volk_32fc_s32f_power_spectral_densitypuppet_32f = (float* logPowerOutput, VolkComplexFloat* complexFFTInput, float normalizationFactor, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32fc_s32f_power_spectral_densitypuppet_32f>(_EP_VOLK_32FC_S32F_POWER_SPECTRAL_DENSITYPUPPET_32F)(logPowerOutput, complexFFTInput, normalizationFactor, num_points);
            volk_32fc_s32f_power_spectral_densitypuppet_32f = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32fc_s32f_power_spectral_densitypuppet_32f>(_EP_VOLK_32FC_S32F_POWER_SPECTRAL_DENSITYPUPPET_32F);
        };
        private const string _EP_VOLK_32FC_S32F_POWER_SPECTRUM_32F = "volk_32fc_s32f_power_spectrum_32f";
        public static VolkDelegates.__d_volk_32fc_s32f_power_spectrum_32f volk_32fc_s32f_power_spectrum_32f = (float* logPowerOutput, VolkComplexFloat* complexFFTInput, float normalizationFactor, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32fc_s32f_power_spectrum_32f>(_EP_VOLK_32FC_S32F_POWER_SPECTRUM_32F)(logPowerOutput, complexFFTInput, normalizationFactor, num_points);
            volk_32fc_s32f_power_spectrum_32f = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32fc_s32f_power_spectrum_32f>(_EP_VOLK_32FC_S32F_POWER_SPECTRUM_32F);
        };
        private const string _EP_VOLK_32FC_S32F_X2_POWER_SPECTRAL_DENSITY_32F = "volk_32fc_s32f_x2_power_spectral_density_32f";
        public static VolkDelegates.__d_volk_32fc_s32f_x2_power_spectral_density_32f volk_32fc_s32f_x2_power_spectral_density_32f = (float* logPowerOutput, VolkComplexFloat* complexFFTInput, float normalizationFactor, float rbw, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32fc_s32f_x2_power_spectral_density_32f>(_EP_VOLK_32FC_S32F_X2_POWER_SPECTRAL_DENSITY_32F)(logPowerOutput, complexFFTInput, normalizationFactor, rbw, num_points);
            volk_32fc_s32f_x2_power_spectral_density_32f = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32fc_s32f_x2_power_spectral_density_32f>(_EP_VOLK_32FC_S32F_X2_POWER_SPECTRAL_DENSITY_32F);
        };
        private const string _EP_VOLK_32FC_S32FC_MULTIPLY_32FC = "volk_32fc_s32fc_multiply_32fc";
        public static VolkDelegates.__d_volk_32fc_s32fc_multiply_32fc volk_32fc_s32fc_multiply_32fc = (VolkComplexFloat* cVector, VolkComplexFloat* aVector, VolkComplexFloat scalar, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32fc_s32fc_multiply_32fc>(_EP_VOLK_32FC_S32FC_MULTIPLY_32FC)(cVector, aVector, scalar, num_points);
            volk_32fc_s32fc_multiply_32fc = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32fc_s32fc_multiply_32fc>(_EP_VOLK_32FC_S32FC_MULTIPLY_32FC);
        };
        private const string _EP_VOLK_32FC_S32FC_ROTATORPUPPET_32FC = "volk_32fc_s32fc_rotatorpuppet_32fc";
        public static VolkDelegates.__d_volk_32fc_s32fc_rotatorpuppet_32fc volk_32fc_s32fc_rotatorpuppet_32fc = (VolkComplexFloat* outVector, VolkComplexFloat* inVector, VolkComplexFloat phase_inc, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32fc_s32fc_rotatorpuppet_32fc>(_EP_VOLK_32FC_S32FC_ROTATORPUPPET_32FC)(outVector, inVector, phase_inc, num_points);
            volk_32fc_s32fc_rotatorpuppet_32fc = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32fc_s32fc_rotatorpuppet_32fc>(_EP_VOLK_32FC_S32FC_ROTATORPUPPET_32FC);
        };
        private const string _EP_VOLK_32FC_S32FC_X2_ROTATOR_32FC = "volk_32fc_s32fc_x2_rotator_32fc";
        public static VolkDelegates.__d_volk_32fc_s32fc_x2_rotator_32fc volk_32fc_s32fc_x2_rotator_32fc = (VolkComplexFloat* outVector, VolkComplexFloat* inVector, VolkComplexFloat phase_inc, VolkComplexFloat* phase, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32fc_s32fc_x2_rotator_32fc>(_EP_VOLK_32FC_S32FC_X2_ROTATOR_32FC)(outVector, inVector, phase_inc, phase, num_points);
            volk_32fc_s32fc_x2_rotator_32fc = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32fc_s32fc_x2_rotator_32fc>(_EP_VOLK_32FC_S32FC_X2_ROTATOR_32FC);
        };
        private const string _EP_VOLK_32FC_X2_ADD_32FC = "volk_32fc_x2_add_32fc";
        public static VolkDelegates.__d_volk_32fc_x2_add_32fc volk_32fc_x2_add_32fc = (VolkComplexFloat* cVector, VolkComplexFloat* aVector, VolkComplexFloat* bVector, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32fc_x2_add_32fc>(_EP_VOLK_32FC_X2_ADD_32FC)(cVector, aVector, bVector, num_points);
            volk_32fc_x2_add_32fc = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32fc_x2_add_32fc>(_EP_VOLK_32FC_X2_ADD_32FC);
        };
        private const string _EP_VOLK_32FC_X2_CONJUGATE_DOT_PROD_32FC = "volk_32fc_x2_conjugate_dot_prod_32fc";
        public static VolkDelegates.__d_volk_32fc_x2_conjugate_dot_prod_32fc volk_32fc_x2_conjugate_dot_prod_32fc = (VolkComplexFloat* result, VolkComplexFloat* input, VolkComplexFloat* taps, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32fc_x2_conjugate_dot_prod_32fc>(_EP_VOLK_32FC_X2_CONJUGATE_DOT_PROD_32FC)(result, input, taps, num_points);
            volk_32fc_x2_conjugate_dot_prod_32fc = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32fc_x2_conjugate_dot_prod_32fc>(_EP_VOLK_32FC_X2_CONJUGATE_DOT_PROD_32FC);
        };
        private const string _EP_VOLK_32FC_X2_DIVIDE_32FC = "volk_32fc_x2_divide_32fc";
        public static VolkDelegates.__d_volk_32fc_x2_divide_32fc volk_32fc_x2_divide_32fc = (VolkComplexFloat* cVector, VolkComplexFloat* aVector, VolkComplexFloat* bVector, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32fc_x2_divide_32fc>(_EP_VOLK_32FC_X2_DIVIDE_32FC)(cVector, aVector, bVector, num_points);
            volk_32fc_x2_divide_32fc = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32fc_x2_divide_32fc>(_EP_VOLK_32FC_X2_DIVIDE_32FC);
        };
        private const string _EP_VOLK_32FC_X2_DOT_PROD_32FC = "volk_32fc_x2_dot_prod_32fc";
        public static VolkDelegates.__d_volk_32fc_x2_dot_prod_32fc volk_32fc_x2_dot_prod_32fc = (VolkComplexFloat* result, VolkComplexFloat* input, VolkComplexFloat* taps, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32fc_x2_dot_prod_32fc>(_EP_VOLK_32FC_X2_DOT_PROD_32FC)(result, input, taps, num_points);
            volk_32fc_x2_dot_prod_32fc = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32fc_x2_dot_prod_32fc>(_EP_VOLK_32FC_X2_DOT_PROD_32FC);
        };
        private const string _EP_VOLK_32FC_X2_MULTIPLY_32FC = "volk_32fc_x2_multiply_32fc";
        public static VolkDelegates.__d_volk_32fc_x2_multiply_32fc volk_32fc_x2_multiply_32fc = (VolkComplexFloat* cVector, VolkComplexFloat* aVector, VolkComplexFloat* bVector, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32fc_x2_multiply_32fc>(_EP_VOLK_32FC_X2_MULTIPLY_32FC)(cVector, aVector, bVector, num_points);
            volk_32fc_x2_multiply_32fc = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32fc_x2_multiply_32fc>(_EP_VOLK_32FC_X2_MULTIPLY_32FC);
        };
        private const string _EP_VOLK_32FC_X2_MULTIPLY_CONJUGATE_32FC = "volk_32fc_x2_multiply_conjugate_32fc";
        public static VolkDelegates.__d_volk_32fc_x2_multiply_conjugate_32fc volk_32fc_x2_multiply_conjugate_32fc = (VolkComplexFloat* cVector, VolkComplexFloat* aVector, VolkComplexFloat* bVector, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32fc_x2_multiply_conjugate_32fc>(_EP_VOLK_32FC_X2_MULTIPLY_CONJUGATE_32FC)(cVector, aVector, bVector, num_points);
            volk_32fc_x2_multiply_conjugate_32fc = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32fc_x2_multiply_conjugate_32fc>(_EP_VOLK_32FC_X2_MULTIPLY_CONJUGATE_32FC);
        };
        private const string _EP_VOLK_32FC_X2_S32F_SQUARE_DIST_SCALAR_MULT_32F = "volk_32fc_x2_s32f_square_dist_scalar_mult_32f";
        public static VolkDelegates.__d_volk_32fc_x2_s32f_square_dist_scalar_mult_32f volk_32fc_x2_s32f_square_dist_scalar_mult_32f = (float* target, VolkComplexFloat* src0, VolkComplexFloat* points, float scalar, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32fc_x2_s32f_square_dist_scalar_mult_32f>(_EP_VOLK_32FC_X2_S32F_SQUARE_DIST_SCALAR_MULT_32F)(target, src0, points, scalar, num_points);
            volk_32fc_x2_s32f_square_dist_scalar_mult_32f = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32fc_x2_s32f_square_dist_scalar_mult_32f>(_EP_VOLK_32FC_X2_S32F_SQUARE_DIST_SCALAR_MULT_32F);
        };
        private const string _EP_VOLK_32FC_X2_S32FC_MULTIPLY_CONJUGATE_ADD_32FC = "volk_32fc_x2_s32fc_multiply_conjugate_add_32fc";
        public static VolkDelegates.__d_volk_32fc_x2_s32fc_multiply_conjugate_add_32fc volk_32fc_x2_s32fc_multiply_conjugate_add_32fc = (VolkComplexFloat* cVector, VolkComplexFloat* aVector, VolkComplexFloat* bVector, VolkComplexFloat scalar, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32fc_x2_s32fc_multiply_conjugate_add_32fc>(_EP_VOLK_32FC_X2_S32FC_MULTIPLY_CONJUGATE_ADD_32FC)(cVector, aVector, bVector, scalar, num_points);
            volk_32fc_x2_s32fc_multiply_conjugate_add_32fc = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32fc_x2_s32fc_multiply_conjugate_add_32fc>(_EP_VOLK_32FC_X2_S32FC_MULTIPLY_CONJUGATE_ADD_32FC);
        };
        private const string _EP_VOLK_32FC_X2_SQUARE_DIST_32F = "volk_32fc_x2_square_dist_32f";
        public static VolkDelegates.__d_volk_32fc_x2_square_dist_32f volk_32fc_x2_square_dist_32f = (float* target, VolkComplexFloat* src0, VolkComplexFloat* points, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32fc_x2_square_dist_32f>(_EP_VOLK_32FC_X2_SQUARE_DIST_32F)(target, src0, points, num_points);
            volk_32fc_x2_square_dist_32f = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32fc_x2_square_dist_32f>(_EP_VOLK_32FC_X2_SQUARE_DIST_32F);
        };
        private const string _EP_VOLK_32I_S32F_CONVERT_32F = "volk_32i_s32f_convert_32f";
        public static VolkDelegates.__d_volk_32i_s32f_convert_32f volk_32i_s32f_convert_32f = (float* outputVector, int* inputVector, float scalar, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32i_s32f_convert_32f>(_EP_VOLK_32I_S32F_CONVERT_32F)(outputVector, inputVector, scalar, num_points);
            volk_32i_s32f_convert_32f = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32i_s32f_convert_32f>(_EP_VOLK_32I_S32F_CONVERT_32F);
        };
        private const string _EP_VOLK_32I_X2_AND_32I = "volk_32i_x2_and_32i";
        public static VolkDelegates.__d_volk_32i_x2_and_32i volk_32i_x2_and_32i = (int* cVector, int* aVector, int* bVector, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32i_x2_and_32i>(_EP_VOLK_32I_X2_AND_32I)(cVector, aVector, bVector, num_points);
            volk_32i_x2_and_32i = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32i_x2_and_32i>(_EP_VOLK_32I_X2_AND_32I);
        };
        private const string _EP_VOLK_32I_X2_OR_32I = "volk_32i_x2_or_32i";
        public static VolkDelegates.__d_volk_32i_x2_or_32i volk_32i_x2_or_32i = (int* cVector, int* aVector, int* bVector, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32i_x2_or_32i>(_EP_VOLK_32I_X2_OR_32I)(cVector, aVector, bVector, num_points);
            volk_32i_x2_or_32i = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32i_x2_or_32i>(_EP_VOLK_32I_X2_OR_32I);
        };
        private const string _EP_VOLK_32U_BYTESWAP = "volk_32u_byteswap";
        public static VolkDelegates.__d_volk_32u_byteswap volk_32u_byteswap = (uint* intsToSwap, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32u_byteswap>(_EP_VOLK_32U_BYTESWAP)(intsToSwap, num_points);
            volk_32u_byteswap = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32u_byteswap>(_EP_VOLK_32U_BYTESWAP);
        };
        private const string _EP_VOLK_32U_BYTESWAPPUPPET_32U = "volk_32u_byteswappuppet_32u";
        public static VolkDelegates.__d_volk_32u_byteswappuppet_32u volk_32u_byteswappuppet_32u = (uint* output, uint* intsToSwap, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32u_byteswappuppet_32u>(_EP_VOLK_32U_BYTESWAPPUPPET_32U)(output, intsToSwap, num_points);
            volk_32u_byteswappuppet_32u = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32u_byteswappuppet_32u>(_EP_VOLK_32U_BYTESWAPPUPPET_32U);
        };
        private const string _EP_VOLK_32U_POPCNT = "volk_32u_popcnt";
        public static VolkDelegates.__d_volk_32u_popcnt volk_32u_popcnt = (uint* ret, uint value) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32u_popcnt>(_EP_VOLK_32U_POPCNT)(ret, value);
            volk_32u_popcnt = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32u_popcnt>(_EP_VOLK_32U_POPCNT);
        };
        private const string _EP_VOLK_32U_POPCNTPUPPET_32U = "volk_32u_popcntpuppet_32u";
        public static VolkDelegates.__d_volk_32u_popcntpuppet_32u volk_32u_popcntpuppet_32u = (uint* outVector, uint* inVector, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32u_popcntpuppet_32u>(_EP_VOLK_32U_POPCNTPUPPET_32U)(outVector, inVector, num_points);
            volk_32u_popcntpuppet_32u = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32u_popcntpuppet_32u>(_EP_VOLK_32U_POPCNTPUPPET_32U);
        };
        private const string _EP_VOLK_32U_REVERSE_32U = "volk_32u_reverse_32u";
        public static VolkDelegates.__d_volk_32u_reverse_32u volk_32u_reverse_32u = (uint* _out, uint* _in, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32u_reverse_32u>(_EP_VOLK_32U_REVERSE_32U)(_out, _in, num_points);
            volk_32u_reverse_32u = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_32u_reverse_32u>(_EP_VOLK_32U_REVERSE_32U);
        };
        private const string _EP_VOLK_64F_CONVERT_32F = "volk_64f_convert_32f";
        public static VolkDelegates.__d_volk_64f_convert_32f volk_64f_convert_32f = (float* outputVector, double* inputVector, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_64f_convert_32f>(_EP_VOLK_64F_CONVERT_32F)(outputVector, inputVector, num_points);
            volk_64f_convert_32f = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_64f_convert_32f>(_EP_VOLK_64F_CONVERT_32F);
        };
        private const string _EP_VOLK_64F_X2_ADD_64F = "volk_64f_x2_add_64f";
        public static VolkDelegates.__d_volk_64f_x2_add_64f volk_64f_x2_add_64f = (double* cVector, double* aVector, double* bVector, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_64f_x2_add_64f>(_EP_VOLK_64F_X2_ADD_64F)(cVector, aVector, bVector, num_points);
            volk_64f_x2_add_64f = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_64f_x2_add_64f>(_EP_VOLK_64F_X2_ADD_64F);
        };
        private const string _EP_VOLK_64F_X2_MAX_64F = "volk_64f_x2_max_64f";
        public static VolkDelegates.__d_volk_64f_x2_max_64f volk_64f_x2_max_64f = (double* cVector, double* aVector, double* bVector, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_64f_x2_max_64f>(_EP_VOLK_64F_X2_MAX_64F)(cVector, aVector, bVector, num_points);
            volk_64f_x2_max_64f = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_64f_x2_max_64f>(_EP_VOLK_64F_X2_MAX_64F);
        };
        private const string _EP_VOLK_64F_X2_MIN_64F = "volk_64f_x2_min_64f";
        public static VolkDelegates.__d_volk_64f_x2_min_64f volk_64f_x2_min_64f = (double* cVector, double* aVector, double* bVector, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_64f_x2_min_64f>(_EP_VOLK_64F_X2_MIN_64F)(cVector, aVector, bVector, num_points);
            volk_64f_x2_min_64f = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_64f_x2_min_64f>(_EP_VOLK_64F_X2_MIN_64F);
        };
        private const string _EP_VOLK_64F_X2_MULTIPLY_64F = "volk_64f_x2_multiply_64f";
        public static VolkDelegates.__d_volk_64f_x2_multiply_64f volk_64f_x2_multiply_64f = (double* cVector, double* aVector, double* bVector, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_64f_x2_multiply_64f>(_EP_VOLK_64F_X2_MULTIPLY_64F)(cVector, aVector, bVector, num_points);
            volk_64f_x2_multiply_64f = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_64f_x2_multiply_64f>(_EP_VOLK_64F_X2_MULTIPLY_64F);
        };
        private const string _EP_VOLK_64U_BYTESWAP = "volk_64u_byteswap";
        public static VolkDelegates.__d_volk_64u_byteswap volk_64u_byteswap = (ulong* intsToSwap, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_64u_byteswap>(_EP_VOLK_64U_BYTESWAP)(intsToSwap, num_points);
            volk_64u_byteswap = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_64u_byteswap>(_EP_VOLK_64U_BYTESWAP);
        };
        private const string _EP_VOLK_64U_BYTESWAPPUPPET_64U = "volk_64u_byteswappuppet_64u";
        public static VolkDelegates.__d_volk_64u_byteswappuppet_64u volk_64u_byteswappuppet_64u = (ulong* output, ulong* intsToSwap, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_64u_byteswappuppet_64u>(_EP_VOLK_64U_BYTESWAPPUPPET_64U)(output, intsToSwap, num_points);
            volk_64u_byteswappuppet_64u = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_64u_byteswappuppet_64u>(_EP_VOLK_64U_BYTESWAPPUPPET_64U);
        };
        private const string _EP_VOLK_64U_POPCNT = "volk_64u_popcnt";
        public static VolkDelegates.__d_volk_64u_popcnt volk_64u_popcnt = (ulong* ret, ulong value) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_64u_popcnt>(_EP_VOLK_64U_POPCNT)(ret, value);
            volk_64u_popcnt = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_64u_popcnt>(_EP_VOLK_64U_POPCNT);
        };
        private const string _EP_VOLK_64U_POPCNTPUPPET_64U = "volk_64u_popcntpuppet_64u";
        public static VolkDelegates.__d_volk_64u_popcntpuppet_64u volk_64u_popcntpuppet_64u = (ulong* outVector, ulong* inVector, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_64u_popcntpuppet_64u>(_EP_VOLK_64U_POPCNTPUPPET_64U)(outVector, inVector, num_points);
            volk_64u_popcntpuppet_64u = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_64u_popcntpuppet_64u>(_EP_VOLK_64U_POPCNTPUPPET_64U);
        };
        private const string _EP_VOLK_8I_CONVERT_16I = "volk_8i_convert_16i";
        public static VolkDelegates.__d_volk_8i_convert_16i volk_8i_convert_16i = (short* outputVector, sbyte* inputVector, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_8i_convert_16i>(_EP_VOLK_8I_CONVERT_16I)(outputVector, inputVector, num_points);
            volk_8i_convert_16i = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_8i_convert_16i>(_EP_VOLK_8I_CONVERT_16I);
        };
        private const string _EP_VOLK_8I_S32F_CONVERT_32F = "volk_8i_s32f_convert_32f";
        public static VolkDelegates.__d_volk_8i_s32f_convert_32f volk_8i_s32f_convert_32f = (float* outputVector, sbyte* inputVector, float scalar, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_8i_s32f_convert_32f>(_EP_VOLK_8I_S32F_CONVERT_32F)(outputVector, inputVector, scalar, num_points);
            volk_8i_s32f_convert_32f = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_8i_s32f_convert_32f>(_EP_VOLK_8I_S32F_CONVERT_32F);
        };
        private const string _EP_VOLK_8IC_DEINTERLEAVE_16I_X2 = "volk_8ic_deinterleave_16i_x2";
        public static VolkDelegates.__d_volk_8ic_deinterleave_16i_x2 volk_8ic_deinterleave_16i_x2 = (short* iBuffer, short* qBuffer, VolkComplexByte* complexVector, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_8ic_deinterleave_16i_x2>(_EP_VOLK_8IC_DEINTERLEAVE_16I_X2)(iBuffer, qBuffer, complexVector, num_points);
            volk_8ic_deinterleave_16i_x2 = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_8ic_deinterleave_16i_x2>(_EP_VOLK_8IC_DEINTERLEAVE_16I_X2);
        };
        private const string _EP_VOLK_8IC_DEINTERLEAVE_REAL_16I = "volk_8ic_deinterleave_real_16i";
        public static VolkDelegates.__d_volk_8ic_deinterleave_real_16i volk_8ic_deinterleave_real_16i = (short* iBuffer, VolkComplexByte* complexVector, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_8ic_deinterleave_real_16i>(_EP_VOLK_8IC_DEINTERLEAVE_REAL_16I)(iBuffer, complexVector, num_points);
            volk_8ic_deinterleave_real_16i = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_8ic_deinterleave_real_16i>(_EP_VOLK_8IC_DEINTERLEAVE_REAL_16I);
        };
        private const string _EP_VOLK_8IC_DEINTERLEAVE_REAL_8I = "volk_8ic_deinterleave_real_8i";
        public static VolkDelegates.__d_volk_8ic_deinterleave_real_8i volk_8ic_deinterleave_real_8i = (sbyte* iBuffer, VolkComplexByte* complexVector, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_8ic_deinterleave_real_8i>(_EP_VOLK_8IC_DEINTERLEAVE_REAL_8I)(iBuffer, complexVector, num_points);
            volk_8ic_deinterleave_real_8i = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_8ic_deinterleave_real_8i>(_EP_VOLK_8IC_DEINTERLEAVE_REAL_8I);
        };
        private const string _EP_VOLK_8IC_S32F_DEINTERLEAVE_32F_X2 = "volk_8ic_s32f_deinterleave_32f_x2";
        public static VolkDelegates.__d_volk_8ic_s32f_deinterleave_32f_x2 volk_8ic_s32f_deinterleave_32f_x2 = (float* iBuffer, float* qBuffer, VolkComplexByte* complexVector, float scalar, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_8ic_s32f_deinterleave_32f_x2>(_EP_VOLK_8IC_S32F_DEINTERLEAVE_32F_X2)(iBuffer, qBuffer, complexVector, scalar, num_points);
            volk_8ic_s32f_deinterleave_32f_x2 = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_8ic_s32f_deinterleave_32f_x2>(_EP_VOLK_8IC_S32F_DEINTERLEAVE_32F_X2);
        };
        private const string _EP_VOLK_8IC_S32F_DEINTERLEAVE_REAL_32F = "volk_8ic_s32f_deinterleave_real_32f";
        public static VolkDelegates.__d_volk_8ic_s32f_deinterleave_real_32f volk_8ic_s32f_deinterleave_real_32f = (float* iBuffer, VolkComplexByte* complexVector, float scalar, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_8ic_s32f_deinterleave_real_32f>(_EP_VOLK_8IC_S32F_DEINTERLEAVE_REAL_32F)(iBuffer, complexVector, scalar, num_points);
            volk_8ic_s32f_deinterleave_real_32f = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_8ic_s32f_deinterleave_real_32f>(_EP_VOLK_8IC_S32F_DEINTERLEAVE_REAL_32F);
        };
        private const string _EP_VOLK_8IC_X2_MULTIPLY_CONJUGATE_16IC = "volk_8ic_x2_multiply_conjugate_16ic";
        public static VolkDelegates.__d_volk_8ic_x2_multiply_conjugate_16ic volk_8ic_x2_multiply_conjugate_16ic = (VolkComplexShort* cVector, VolkComplexByte* aVector, VolkComplexByte* bVector, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_8ic_x2_multiply_conjugate_16ic>(_EP_VOLK_8IC_X2_MULTIPLY_CONJUGATE_16IC)(cVector, aVector, bVector, num_points);
            volk_8ic_x2_multiply_conjugate_16ic = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_8ic_x2_multiply_conjugate_16ic>(_EP_VOLK_8IC_X2_MULTIPLY_CONJUGATE_16IC);
        };
        private const string _EP_VOLK_8IC_X2_S32F_MULTIPLY_CONJUGATE_32FC = "volk_8ic_x2_s32f_multiply_conjugate_32fc";
        public static VolkDelegates.__d_volk_8ic_x2_s32f_multiply_conjugate_32fc volk_8ic_x2_s32f_multiply_conjugate_32fc = (VolkComplexFloat* cVector, VolkComplexByte* aVector, VolkComplexByte* bVector, float scalar, int num_points) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_8ic_x2_s32f_multiply_conjugate_32fc>(_EP_VOLK_8IC_X2_S32F_MULTIPLY_CONJUGATE_32FC)(cVector, aVector, bVector, scalar, num_points);
            volk_8ic_x2_s32f_multiply_conjugate_32fc = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_8ic_x2_s32f_multiply_conjugate_32fc>(_EP_VOLK_8IC_X2_S32F_MULTIPLY_CONJUGATE_32FC);
        };
        private const string _EP_VOLK_8U_CONV_K7_R2PUPPET_8U = "volk_8u_conv_k7_r2puppet_8u";
        public static VolkDelegates.__d_volk_8u_conv_k7_r2puppet_8u volk_8u_conv_k7_r2puppet_8u = (byte* syms, byte* dec, int framebits) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_8u_conv_k7_r2puppet_8u>(_EP_VOLK_8U_CONV_K7_R2PUPPET_8U)(syms, dec, framebits);
            volk_8u_conv_k7_r2puppet_8u = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_8u_conv_k7_r2puppet_8u>(_EP_VOLK_8U_CONV_K7_R2PUPPET_8U);
        };
        private const string _EP_VOLK_8U_X2_ENCODEFRAMEPOLAR_8U = "volk_8u_x2_encodeframepolar_8u";
        public static VolkDelegates.__d_volk_8u_x2_encodeframepolar_8u volk_8u_x2_encodeframepolar_8u = (byte* frame, byte* temp, int frame_size) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_8u_x2_encodeframepolar_8u>(_EP_VOLK_8U_X2_ENCODEFRAMEPOLAR_8U)(frame, temp, frame_size);
            volk_8u_x2_encodeframepolar_8u = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_8u_x2_encodeframepolar_8u>(_EP_VOLK_8U_X2_ENCODEFRAMEPOLAR_8U);
        };
        private const string _EP_VOLK_8U_X3_ENCODEPOLAR_8U_X2 = "volk_8u_x3_encodepolar_8u_x2";
        public static VolkDelegates.__d_volk_8u_x3_encodepolar_8u_x2 volk_8u_x3_encodepolar_8u_x2 = (byte* frame, byte* temp, byte* frozen_bit_mask, byte* frozen_bits, byte* info_bits, int frame_size) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_8u_x3_encodepolar_8u_x2>(_EP_VOLK_8U_X3_ENCODEPOLAR_8U_X2)(frame, temp, frozen_bit_mask, frozen_bits, info_bits, frame_size);
            volk_8u_x3_encodepolar_8u_x2 = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_8u_x3_encodepolar_8u_x2>(_EP_VOLK_8U_X3_ENCODEPOLAR_8U_X2);
        };
        private const string _EP_VOLK_8U_X3_ENCODEPOLARPUPPET_8U = "volk_8u_x3_encodepolarpuppet_8u";
        public static VolkDelegates.__d_volk_8u_x3_encodepolarpuppet_8u volk_8u_x3_encodepolarpuppet_8u = (byte* frame, byte* frozen_bit_mask, byte* frozen_bits, byte* info_bits, int frame_size) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_8u_x3_encodepolarpuppet_8u>(_EP_VOLK_8U_X3_ENCODEPOLARPUPPET_8U)(frame, frozen_bit_mask, frozen_bits, info_bits, frame_size);
            volk_8u_x3_encodepolarpuppet_8u = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_8u_x3_encodepolarpuppet_8u>(_EP_VOLK_8U_X3_ENCODEPOLARPUPPET_8U);
        };
        private const string _EP_VOLK_8U_X4_CONV_K7_R2_8U = "volk_8u_x4_conv_k7_r2_8u";
        public static VolkDelegates.__d_volk_8u_x4_conv_k7_r2_8u volk_8u_x4_conv_k7_r2_8u = (byte* Y, byte* X, byte* syms, byte* dec, int framebits, int excess, byte* Branchtab) =>
        {
            VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_8u_x4_conv_k7_r2_8u>(_EP_VOLK_8U_X4_CONV_K7_R2_8U)(Y, X, syms, dec, framebits, excess, Branchtab);
            volk_8u_x4_conv_k7_r2_8u = VolkNative.volk.GetResolvedMethodPointer<VolkDelegates.__d_volk_8u_x4_conv_k7_r2_8u>(_EP_VOLK_8U_X4_CONV_K7_R2_8U);
        };
    }
}
