// Generated by Fuzzlyn v1.1 on 2018-09-19 08:47:23
// Seed: 12403793701911697873
// Reduced from 132.3 KiB to 1.1 KiB in 00:02:13
// Debug: Outputs 1
// Release: Outputs 0
class C0
{
    public long F0;
    public int F1;
    public int F3;
    public C0(int f1)
    {
        F1 = f1;
    }
}

struct S0
{
    public int F0;
    public C0 F1;
    public C0 F4;
    public S0(C0 f1, C0 f4): this()
    {
        F1 = f1;
        F4 = f4;
    }
}

public class Program
{
    static C0[] s_8 = new C0[]{new C0(0)};
    static S0 s_20 = new S0(new C0(1), new C0(1));
    static S0[][][] s_31 = new S0[][][]{new S0[][]{new S0[]{new S0(new C0(0), new C0(0))}}};
    public static void Main()
    {
        var vr14 = new S0(new C0(0), new C0(1));
        M14(vr14, M12((sbyte)M18(s_20)));
        System.Console.WriteLine(s_20.F1.F1);
    }

    static ref S0 M12(sbyte arg0)
    {
        System.Console.WriteLine(s_20.F1.F1);
        return ref s_31[0][0][0];
    }

    static int[] M14(S0 arg0, S0 arg1)
    {
        arg0.F1.F1 = s_8[0].F3;
        return new int[]{0, 0, 0, 1, 0, 1, 0, 0};
    }

    static ref long M18(S0 arg0)
    {
        System.Console.WriteLine(arg0.F0);
        return ref arg0.F4.F0;
    }
}
