// Generated by Fuzzlyn v1.1 on 2018-09-07 09:06:47
// Seed: 18186712687393848458
// Reduced from 463.4 KiB to 1.4 KiB in 00:13:06
// Debug: Outputs 0
// Release: Outputs -1938423808
class C0
{
    public int F3;
    public uint F6;
}

struct S0
{
    public C0 F1;
    public bool F3;
    public C0 F6;
    public S0(C0 f1, C0 f6): this()
    {
        F1 = f1;
        F6 = f6;
    }
}

class C1
{
    public ushort F1;
}

class C2
{
    public long F3;
}

struct S3
{
    public int F0;
    public uint F1;
    public short F2;
}

class C3
{
    public S3 F0;
}

public class Program
{
    static C3 s_32 = new C3();
    static C1 s_44 = new C1();
    static ushort[] s_49 = new ushort[]{0};
    public static void Main()
    {
        M61();
    }

    static void M61()
    {
        var vr0 = new S3();
        var vr1 = new C2();
        var vr2 = new S0(new C0(), new C0());
        var vr3 = new S0[]{new S0(new C0(), new C0())};
        M64(ref s_32.F0, vr0, vr2, vr1, vr3, ref s_49);
    }

    static void M64(ref S3 arg0, S3 arg1, S0 arg2, C2 arg3, S0[] arg4, ref ushort[] arg5)
    {
        S3 var0 = arg1;
        int[, ] var1 = new int[, ]{{0}};
        arg2.F6.F6 = arg0.F1;
        s_44.F1 = (ushort)var0.F1;
        int var2 = (int)(1401779666U * var0.F2);
        System.Console.WriteLine(arg3.F3);
        System.Console.WriteLine(arg4[0].F1.F3);
        System.Console.WriteLine(arg5[0]);
        System.Console.WriteLine(var0.F0);
        System.Console.WriteLine(var2);
    }
}
