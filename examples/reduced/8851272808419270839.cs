// Generated by Fuzzlyn v1.1 on 2018-09-25 22:29:03
// Seed: 8851272808419270839
// Reduced from 175.8 KiB to 0.9 KiB in 00:03:45
// Debug: Outputs 0
// Release: Outputs -16
public class Program
{
    static bool s_18;
    static int[, ] s_21 = new int[, ]{{0}};
    static short s_26 = 1;
    public static void Main()
    {
        bool vr1 = M26(-1, ref s_21[0, 0], ref s_26, 0) == 0;
    }

    static ulong M26(sbyte arg0, ref int arg2, ref short arg4, uint arg5)
    {
        byte var2 = default(byte);
        sbyte var3 = default(sbyte);
        try
        {
            arg5 = (uint)arg4;
        }
        finally
        {
            arg0 = (sbyte)(arg2-- % arg5--);
            M27();
            arg0 /= 16;
            M27();
            if (s_18)
            {
                System.Console.WriteLine(var2);
            }

            System.Console.WriteLine(var3);
        }

        System.Console.WriteLine(arg0);
        return 0;
    }

    static byte[, ] M27()
    {
        return default(byte[, ]);
    }
}