// Generated by Fuzzlyn v1.1 on 2018-09-08 16:38:22
// Seed: 16234929744063655982
// Reduced from 70.1 KiB to 0.5 KiB in 00:01:26
// Debug: Outputs -1723793982
// Release: Outputs 1480801218
public class Program
{
    static short s_3;
    static ulong[][][][, ] s_11 = new ulong[][][][, ]{new ulong[][][, ]{new ulong[][, ]{new ulong[, ]{{0}}}}};
    public static void Main()
    {
        M22(0);
    }

    static void M22(sbyte arg0)
    {
        arg0 = (sbyte)(-1 + s_3);
        var vr2 = 1723793982 * arg0;
        System.Console.WriteLine(vr2);
        try
        {
            s_11[0][0] = s_11[0][0];
        }
        finally
        {
            arg0 %= arg0;
        }
    }
}