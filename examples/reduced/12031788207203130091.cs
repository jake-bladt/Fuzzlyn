// Generated by Fuzzlyn v1.1 on 2018-11-16 22:48:35
// Seed: 12031788207203130091
// Reduced from 202.1 KiB to 1.1 KiB in 00:07:16
// Debug: Outputs 13
// Release: Outputs -19
public class Program
{
    static uint s_7 = 2335511959U;
    static byte[] s_22 = new byte[]{0};
    static uint s_28;
    static sbyte[][][] s_33 = new sbyte[][][]{new sbyte[][]{new sbyte[]{0}}};
    public static void Main()
    {
        var vr12 = s_33[0][0];
        byte vr15 = default(byte);
        var vr14 = s_33[0][0][0];
        M41(vr12, vr15, vr14);
        System.Console.WriteLine(s_33[0][0][0]);
    }

    static void M41(sbyte[] arg1, byte arg5, sbyte arg6)
    {
        long var3 = default(long);
        try
        {
            s_28 = s_28;
        }
        finally
        {
            var vr2 = new bool[]{true};
            var vr3 = new uint[]{0};
            var vr4 = s_22[0]++ + var3--;
            M48(vr2, ref arg5, arg5, (short)M42());
            System.Console.WriteLine(var3);
        }

        arg6 += (sbyte)s_7;
        arg6 /= -8;
        arg1[0] = arg6;
    }

    static ushort M42()
    {
        return default(ushort);
    }

    static long M48(bool[] arg1, ref byte arg2, byte arg3, short arg4)
    {
        return default(long);
    }
}