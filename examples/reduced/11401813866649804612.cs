// Generated by Fuzzlyn v1.1 on 2018-09-05 04:13:47
// Seed: 11401813866649804612
// Reduced from 261.3 KiB to 0.5 KiB in 00:06:31
// Debug: Outputs -1
// Release: Outputs 3
public class Program
{
    static sbyte s_80 = -1;
    public static void Main()
    {
        M91(1);
    }

    static void M91(sbyte arg0)
    {
        long var4 = default(long);
        arg0 |= s_80;
        arg0 %= 126;
        try
        {
            System.Console.WriteLine(var4);
        }
        finally
        {
            int vr5 = default(int);
            ulong var5 = (ulong)(vr5 % arg0);
        }

        System.Console.WriteLine(arg0);
    }
}
