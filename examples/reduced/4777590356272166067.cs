// Generated by Fuzzlyn on 2018-06-25 14:24:33
// Seed: 4777590356272166067
// Reduced from 94.2 KiB to 0.7 KiB
// Debug: Outputs 12277080105761855924
// Release: Outputs 0
class C0
{
    public sbyte F0;
    public ulong F6;
    public ulong F7;
    public C0(ulong f7)
    {
        F7 = f7;
    }
}

struct S0
{
    public C0 F2;
    public S0(C0 f2): this()
    {
        F2 = f2;
    }
}

struct S1
{
    public S0 F0;
    public S0 F2;
    public S1(S0 f0, S0 f2): this()
    {
        F0 = f0;
        F2 = f2;
    }
}

public class Program
{
    public static void Main()
    {
        var vr11 = new S1[]{new S1(new S0(new C0(12277080105761855924UL)), new S0(new C0(0)))};
        vr11[0].F2.F2.F0 = vr11[0].F2.F2.F0;
        vr11[0].F2.F2 = new C0(0);
        vr11[0].F2.F2.F6 = vr11[0].F0.F2.F7;
        System.Console.WriteLine(vr11[0].F2.F2.F6);
    }
}
