// Generated by Fuzzlyn v1.1 on 2018-11-23 13:01:55
// Seed: 10854041746042637628
// Reduced from 251.3 KiB to 0.7 KiB in 00:05:22
// Debug: Outputs 0
// Release: Outputs -40
struct S0
{
    public short F0;
}

struct S1
{
    public sbyte F0;
    public long F2;
    public S0 F3;
}

public class Program
{
    static ulong[] s_20 = new ulong[]{0};
    static S1 s_28;
    static S1 s_29;
    static S1[] s_36 = new S1[]{new S1()};
    public static void Main()
    {
        var vr6 = new S0[, ]{{new S0()}};
        M36(s_29, M34(ref s_36[0], 0, 0, vr6, ref s_29.F3.F0, ref s_28.F0, ref s_20[0]));
    }

    static ref S1 M34(ref S1 arg0, sbyte arg4, sbyte arg5, S0[, ] arg6, ref short arg7, ref sbyte arg8, ref ulong arg9)
    {
        System.Console.WriteLine(arg0.F0);
        return ref arg0;
    }

    static void M36(S1 arg0, S1 arg1)
    {
        System.Console.WriteLine(arg0.F0);
    }
}