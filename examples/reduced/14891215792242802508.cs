// Generated by Fuzzlyn v1.1 on 2018-11-26 22:19:22
// Seed: 14891215792242802508
// Reduced from 482.7 KiB to 0.7 KiB in 00:07:40
// Debug: Outputs True
// Release: Outputs False
struct S0
{
    public ushort F2;
    public ulong F3;
    public short F5;
}

struct S1
{
    public bool F0;
    public bool F1;
    public S0 F3;
    public S1(bool f0): this()
    {
        F0 = f0;
    }
}

public class Program
{
    static S1[] s_12 = new S1[]{new S1(true)};
    static S1 s_27;
    public static void Main()
    {
        var vr3 = new S1(s_12[0].F0);
        S0 vr6 = default(S0);
        bool vr5 = M25(vr3, M26(vr6, ref s_12[0]));
    }

    static bool M25(S1 arg0, S1 arg1)
    {
        System.Console.WriteLine(arg0.F0);
        return true;
    }

    static ref S1 M26(S0 arg0, ref S1 arg2)
    {
        bool var2 = s_27.F1;
        return ref arg2;
    }
}