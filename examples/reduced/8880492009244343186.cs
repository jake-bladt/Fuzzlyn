// Generated by Fuzzlyn v1.1 on 2018-09-29 04:21:06
// Seed: 8880492009244343186
// Reduced from 285.8 KiB to 0.5 KiB in 00:08:00
// Debug: Outputs 0
// Release: Outputs -646
public class Program
{
    static short s_9;
    public static void Main()
    {
        s_9 = -1;
        M100(s_9);
    }

    static void M100(short arg1)
    {
        try
        {
            sbyte[] var0 = new sbyte[]{-1};
        }
        finally
        {
            arg1 = arg1++;
            arg1 = (short)M105(0);
            arg1 %= -6489;
        }

        System.Console.WriteLine(arg1);
    }

    static ulong M105(int arg0)
    {
        System.Console.WriteLine(arg0);
        return 0;
    }
}