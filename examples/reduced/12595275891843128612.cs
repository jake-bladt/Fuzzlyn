// Generated by Fuzzlyn v1.1 on 2018-11-17 19:09:22
// Seed: 12595275891843128612
// Reduced from 256.3 KiB to 0.7 KiB in 00:05:20
// Debug: Outputs 1
// Release: Outputs 0
struct S0
{
    public ushort F0;
    public sbyte F2;
}

struct S1
{
    public ushort F0;
    public S0 F1;
    public int F2;
    public long F3;
    public S1(ushort f0): this()
    {
        F0 = f0;
    }
}

struct S3
{
    public short F0;
    public ulong F4;
    public byte F9;
}

public class Program
{
    static S1 s_8;
    public static void Main()
    {
        var vr2 = new S1(1);
        S3 vr4 = default(S3);
        M35(vr2, M43(vr4));
    }

    static void M35(S1 arg0, S1 arg1)
    {
        System.Console.WriteLine(arg0.F0);
    }

    static ref S1 M43(S3 arg0)
    {
        System.Console.WriteLine(arg0.F0);
        return ref s_8;
    }
}