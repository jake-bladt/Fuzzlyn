// Generated by Fuzzlyn v1.1 on 2018-09-23 11:43:00
// Seed: 11129395879530661282
// Reduced from 209.8 KiB to 0.5 KiB in 00:04:10
// Debug: Outputs True
// Release: Outputs False
public class Program
{
    static int[] s_9 = new int[]{0};
    static short[] s_23 = new short[]{0};
    public static void Main()
    {
        M47(1);
    }

    static void M47(short arg1)
    {
        try
        {
            ++s_23[0];
        }
        finally
        {
            arg1 = (short)(s_9[0] - arg1);
            short var3 = arg1;
            var vr1 = 1 > var3;
            System.Console.WriteLine(vr1);
        }
    }
}