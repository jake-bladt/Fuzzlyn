// Generated by Fuzzlyn v1.1 on 2018-08-27 08:44:21
// Seed: 7094775769349823273
// Reduced from 123.1 KiB to 0.7 KiB in 00:01:53
// Debug: Outputs 0
// Release: Outputs -2
public class Program
{
    static bool s_17;
    static short s_43;
    static sbyte[] s_48;
    public static void Main()
    {
        bool vr7 = M46(-1);
    }

    static bool M46(sbyte arg2)
    {
        try
        {
            s_48 = new sbyte[]{0};
        }
        finally
        {
            arg2 = (sbyte)(arg2 | s_43);
        }

        var vr2 = new sbyte[]{0};
        arg2 = (sbyte)M48(vr2);
        arg2 /= 87;
        System.Console.WriteLine(arg2);
        return false;
    }

    static ushort M48(sbyte[] arg0)
    {
        if (s_17)
        {
            arg0[0] = arg0[0];
            sbyte var0 = arg0[0];
        }

        return 1;
    }
}