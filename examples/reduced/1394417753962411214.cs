// Generated by Fuzzlyn v1.1 on 2018-11-12 00:59:40
// Seed: 1394417753962411214
// Reduced from 241.0 KiB to 0.5 KiB in 00:05:20
// Debug: Outputs 0
// Release: Outputs 122
public class Program
{
    static sbyte s_2;
    static sbyte[] s_27 = new sbyte[]{-1};
    static uint s_36;
    public static void Main()
    {
        var vr6 = s_27[0];
        M45(vr6);
    }

    static void M45(sbyte arg0)
    {
        try
        {
            long[] var7 = new long[]{0};
        }
        finally
        {
            s_36 = (uint)arg0;
            arg0 = s_2;
            arg0 %= 126;
        }

        System.Console.WriteLine(arg0);
    }
}