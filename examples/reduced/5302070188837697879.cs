// Generated by Fuzzlyn v1.1 on 2018-11-29 17:43:23
// Seed: 5302070188837697879
// Reduced from 115.5 KiB to 0.4 KiB in 00:01:56
// Debug: Outputs -1
// Release: Outputs -32766
public class Program
{
    static short s_41;
    public static void Main()
    {
        M37(s_41);
    }

    static void M37(short arg0)
    {
        try
        {
            sbyte[] var0 = new sbyte[]{1};
        }
        finally
        {
            --arg0;
            arg0 %= -32767;
        }

        System.Console.WriteLine(arg0);
    }
}