// Generated by Fuzzlyn v1.1 on 2018-10-06 10:50:50
// Seed: 15862677959382723914
// Reduced from 148.8 KiB to 0.6 KiB in 00:01:42
// Debug: Outputs 0
// Release: Outputs 1
class C0
{
    public uint F4;
    public long F5;
    public C0(uint f4)
    {
        F4 = f4;
    }
}

struct S0
{
    public C0 F1;
    public S0(C0 f1): this()
    {
        F1 = f1;
    }
}

struct S1
{
    public C0 F3;
    public S0 F4;
    public S1(C0 f3, S0 f4): this()
    {
        F3 = f3;
        F4 = f4;
    }
}

public class Program
{
    public static void Main()
    {
        var vr1 = new S1[]{new S1(new C0(0), new S0(new C0(1)))};
        vr1[0].F3.F5 = vr1[0].F4.F1.F5;
        vr1[0].F4.F1 = new C0(0);
        vr1[0].F3.F4 = vr1[0].F4.F1.F4;
        System.Console.WriteLine(vr1[0].F3.F4);
    }
}
