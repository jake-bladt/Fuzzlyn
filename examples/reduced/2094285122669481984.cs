// Generated by Fuzzlyn v1.1 on 2018-08-20 05:28:05
// Seed: 2094285122669481984
// Reduced from 99.9 KiB to 0.5 KiB in 00:02:18
// Debug: Outputs 0
// Release: Outputs 1
struct S0
{
    public uint F0;
    public short F2;
    public S0(uint f0): this()
    {
        F0 = f0;
    }
}

struct S1
{
    public S0 F3;
    public short F5;
    public S1(S0 f3): this()
    {
        F3 = f3;
    }
}

public class Program
{
    static S1[] s_1 = new S1[]{new S1(new S0(1))};
    public static void Main()
    {
        M6() = s_1[0];
        System.Console.WriteLine(s_1[0].F3.F0);
    }

    static ref S1 M6()
    {
        s_1 = new S1[]{new S1(new S0(0))};
        return ref s_1[0];
    }
}