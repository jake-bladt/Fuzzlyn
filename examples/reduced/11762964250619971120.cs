// Generated by Fuzzlyn v1.1 on 2018-09-26 23:34:56
// Seed: 11762964250619971120
// Reduced from 209.0 KiB to 0.9 KiB in 00:03:14
// Debug: Outputs 0
// Release: Outputs 2
struct S0
{
    public sbyte F6;
    public int F9;
    public S0(sbyte f6, int f9): this()
    {
        F6 = f6;
        F9 = f9;
    }
}

class C0
{
    public S0 F2;
    public long F3;
    public C0(long f0, S0 f2)
    {
        F2 = f2;
    }
}

public class Program
{
    static S0[] s_1 = new S0[]{new S0(0, -1)};
    static C0 s_3 = new C0(0, new S0(1, 0));
    static C0[][] s_16 = new C0[][]{new C0[]{new C0(0, new S0(-1, 0))}};
    public static void Main()
    {
        var vr3 = s_16[0][0].F2.F6;
        var vr4 = new C0(M9(vr3), new S0(0, 0));
    }

    static ref long M9(sbyte arg0)
    {
        try
        {
            arg0 = arg0++;
        }
        finally
        {
            arg0 <<= s_1[0].F9;
            arg0 /= -99;
        }

        System.Console.WriteLine(arg0);
        return ref s_3.F3;
    }
}
