// Generated by Fuzzlyn v1.1 on 2018-09-19 01:43:13
// Seed: 9505347292959970273
// Reduced from 175.4 KiB to 0.6 KiB in 00:02:46
// Debug: Outputs 1
// Release: Outputs 0
struct S0
{
    public bool F0;
    public ulong F3;
    public ushort F5;
    public S0(ulong f3): this()
    {
        F3 = f3;
    }
}

struct S2
{
    public S0 F0;
}

struct S3
{
    public S2 F1;
}

public class Program
{
    static S3 s_7;
    static S3 s_12;
    public static void Main()
    {
        var vr5 = new S0(1);
        var vr6 = s_12.F1.F0;
        var vr7 = new S2();
        M7(vr5, M7(vr6, vr7));
    }

    static ref S2 M7(S0 arg0, S2 arg1)
    {
        var vr2 = arg0.F3;
        System.Console.WriteLine(vr2);
        return ref s_7.F1;
    }
}
