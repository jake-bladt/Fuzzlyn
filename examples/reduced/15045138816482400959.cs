// Generated by Fuzzlyn v1.1 on 2018-09-23 20:11:17
// Seed: 15045138816482400959
// Reduced from 136.5 KiB to 0.7 KiB in 00:04:14
// Debug: Outputs -345130065
// Release: Outputs -2139440209
public class Program
{
    static long[] s_1 = new long[]{0};
    static long[][] s_2 = new long[][]{new long[]{0}};
    static ushort s_14 = 56491;
    static short s_24 = 1;
    public static void Main()
    {
        s_2[0] = s_1;
        long vr15 = s_1[0];
        var vr13 = (short)vr15;
        M38(vr13);
    }

    static void M38(short arg0)
    {
        arg0 = (short)s_14;
        ref long vr17 = ref s_1[0];
        vr17 = (arg0 * 38157);
        long vr19 = s_2[0][0];
        System.Console.WriteLine(vr19);
        try
        {
            System.Console.WriteLine(arg0);
        }
        finally
        {
            arg0 %= s_24;
        }
    }
}