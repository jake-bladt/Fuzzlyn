// Generated by Fuzzlyn on 2018-06-25 14:48:54
// Seed: 8294795176124705567
// Reduced from 45.1 KiB to 0.6 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
class C0
{
    public byte F1;
    public ushort F5;
}

class C1
{
    public C0 F4;
    public C0 F5;
    public C1(C0 f4, C0 f5)
    {
        F4 = f4;
        F5 = f5;
    }
}

class C2
{
    public C1 F1;
    public C1 F3;
    public C2(C1 f1, C1 f3)
    {
        F1 = f1;
        F3 = f3;
    }
}

public class Program
{
    static C2[, ] s_4 = new C2[, ]{{new C2(new C1(new C0(), new C0()), new C1(new C0(), new C0()))}};
    public static void Main()
    {
        bool vr1 = 'C' > ((0 & s_4[0, 0].F1.F5.F1) % (s_4[0, 0].F3.F4.F5 | 1));
    }
}
