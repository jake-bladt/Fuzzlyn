// Generated by Fuzzlyn v1.1 on 2018-09-01 15:13:30
// Seed: 12198968547415073864
// Reduced from 253.2 KiB to 0.8 KiB in 00:05:34
// Debug: Outputs -17433
// Release: Outputs 20711
public class Program
{
    static ushort[] s_18 = new ushort[]{0};
    static int s_19;
    static long[, ] s_29 = new long[, ]{{3830828166858507340L}};
    static sbyte s_58;
    public static void Main()
    {
        short vr3 = (short)M61(s_58);
    }

    static int M61(sbyte arg0)
    {
        try
        {
            M62();
        }
        finally
        {
            var vr1 = s_18[0];
            M63(arg0, vr1);
        }

        long vr9 = s_29[0, 0];
        arg0 = (sbyte)(63 + vr9);
        var vr2 = arg0 * 149;
        System.Console.WriteLine(vr2);
        return s_19;
    }

    static bool M62()
    {
        return true;
    }

    static void M63(sbyte arg2, ushort arg3)
    {
        System.Console.WriteLine(arg3);
    }
}
