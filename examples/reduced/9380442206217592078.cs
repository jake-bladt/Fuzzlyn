// Generated by Fuzzlyn v1.1 on 2018-09-08 04:53:48
// Seed: 9380442206217592078
// Reduced from 329.5 KiB to 0.5 KiB in 00:20:14
// Debug: Outputs 19412
// Release: Outputs -4950060
public class Program
{
    static sbyte s_26;
    public static void Main()
    {
        M123(s_26);
    }

    static void M123(sbyte arg1)
    {
        ushort var4 = default(ushort);
        sbyte[] var0 = new sbyte[]{0};
        var0[0] = arg1--;
        var vr1 = arg1 * -19412;
        System.Console.WriteLine(vr1);
        try
        {
            System.Console.WriteLine(var4);
        }
        finally
        {
            M127(arg1);
        }
    }

    static void M127(sbyte arg1)
    {
        arg1 = arg1;
    }
}