// Generated by Fuzzlyn v1.1 on 2018-11-13 22:38:59
// Seed: 15489484879355878996
// Reduced from 131.6 KiB to 0.4 KiB in 00:01:21
// Debug: Outputs 1
// Release: Outputs 0
struct S0
{
    public long F0;
    public long F5;
    public ulong F7;
    public S0(long f0): this()
    {
        F0 = f0;
    }
}

public class Program
{
    static S0 s_2;
    public static void Main()
    {
        var vr13 = new S0(1);
        var vr15 = M4(vr13, M4(s_2, s_2));
    }

    static ref S0 M4(S0 arg0, S0 arg1)
    {
        System.Console.WriteLine(arg0.F0);
        return ref s_2;
    }
}
