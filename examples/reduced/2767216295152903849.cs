// Generated by Fuzzlyn v1.1 on 2018-08-07 03:21:16
// Seed: 2767216295152903849
// Reduced from 248.4 KiB to 0.7 KiB
// Debug: Outputs 9315412890800206305
// Release: Outputs 0
struct S0
{
    public ulong F1;
    public S0(ulong f1): this()
    {
        F1 = f1;
    }
}

struct S1
{
    public S0 F0;
    public ulong F4;
    public S1(S0 f0): this()
    {
        F0 = f0;
    }
}

public class Program
{
    static S1[] s_4 = new S1[]{new S1(new S0(0))};
    static S0 s_8;
    public static void Main()
    {
        ref S1[] vr6 = ref s_4;
        M13() = vr6[0].F0;
        M18(ref s_8.F1) = M18(ref s_4[0].F4);
    }

    static ref S0 M13()
    {
        s_4 = new S1[]{new S1(new S0(9315412890800206305UL))};
        return ref s_8;
    }

    static ref S1 M18(ref ulong arg4)
    {
        System.Console.WriteLine(arg4);
        return ref s_4[0];
    }
}