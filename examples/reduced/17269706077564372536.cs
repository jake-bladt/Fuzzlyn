// Generated by Fuzzlyn v1.1 on 2018-08-20 12:39:24
// Seed: 17269706077564372536
// Reduced from 378.3 KiB to 0.7 KiB in 00:11:38
// Debug: Outputs 0
// Release: Outputs 8192
public class Program
{
    static short[] s_39 = new short[]{1};
    static uint[][][][][] s_46 = new uint[][][][][]{new uint[][][][]{new uint[][][]{new uint[][]{new uint[]{3836854063U}}}}};
    static short s_103;
    public static void Main()
    {
        uint vr8 = s_46[0][0][0][0][0];
        var vr7 = (short)vr8;
        M108(vr7, s_39);
        short vr9 = s_39[0];
        System.Console.WriteLine(vr9);
    }

    static void M108(short arg0, short[] arg1)
    {
        try
        {
            arg0 = s_103;
            arg1[0] = (short)(arg0 / -8);
        }
        finally
        {
            arg0 >>= 0;
        }
    }
}