// Generated by Fuzzlyn v1.1 on 2018-08-20 05:16:01
// Seed: 10262365877832507691
// Reduced from 34.3 KiB to 0.5 KiB in 00:00:45
// Debug: Outputs -659932899
// Release: Outputs -1618134755
public class Program
{
    public static void Main()
    {
        M9(0);
    }

    static void M9(short arg0)
    {
        ulong var0 = default(ulong);
        var vr0 = arg0-- * M10(arg0 * 659932899, arg0);
        try
        {
            System.Console.WriteLine(var0);
        }
        finally
        {
            arg0 %= arg0;
        }
    }

    static short M10(int arg3, short arg5)
    {
        System.Console.WriteLine(arg3);
        return arg5;
    }
}