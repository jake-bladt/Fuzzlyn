// Generated by Fuzzlyn v1.1 on 2018-11-12 00:35:25
// Seed: 10228632584827569082
// Reduced from 29.4 KiB to 0.5 KiB in 00:00:29
// Debug: Outputs False
// Release: Outputs True
struct S0
{
    public ushort F0;
    public long F3;
}

struct S2
{
    public bool F0;
    public S0 F1;
    public S2(bool f0): this()
    {
        F0 = f0;
    }
}

public class Program
{
    static S2 s_3;
    public static void Main()
    {
        var vr3 = new S2(true);
        var vr6 = new S2(true);
        M3(s_3, M3(vr3, vr6));
    }

    static ref S2 M3(S2 arg0, S2 arg1)
    {
        System.Console.WriteLine(arg0.F0);
        return ref s_3;
    }
}