// Generated by Fuzzlyn v1.1 on 2018-09-12 21:53:59
// Seed: 9229982252420580498
// Reduced from 365.9 KiB to 0.9 KiB in 00:18:01
// Debug: Outputs 0
// Release: Outputs -16
public class Program
{
    static bool s_1 = true;
    static short s_12;
    static short s_14;
    static short s_78;
    public static void Main()
    {
        M78(s_12);
        System.Console.WriteLine(s_78);
    }

    static void M78(short arg0)
    {
        short var0 = s_12;
        try
        {
            arg0 = -1;
        }
        finally
        {
            var vr4 = new long[][][]{new long[][]{new long[]{0}}, new long[][]{new long[]{0}}, new long[][]{new long[]{0}}, new long[][]{new long[]{0}}, new long[][]{new long[]{0}}, new long[][]{new long[]{0}}, new long[][]{new long[]{0}}, new long[][]{new long[]{0}}, new long[][]{new long[]{0}}, new long[][]{new long[]{0}}};
        }

        if (s_1)
        {
            arg0 = s_14;
            var0 = arg0;
            var0 %= 126;
        }

        s_78 = var0;
        var0 = arg0;
        System.Console.WriteLine(var0);
    }
}
