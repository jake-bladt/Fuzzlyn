// Generated by Fuzzlyn v1.1 on 2018-09-14 09:49:19
// Seed: 5873826598764493791
// Reduced from 238.2 KiB to 0.9 KiB in 00:04:14
// Debug: Outputs 0
// Release: Outputs -196
struct S0
{
    public sbyte F2;
    public bool F4;
}

struct S1
{
    public S0 F3;
}

class C0
{
    public short F1;
    public S1 F5;
}

class C1
{
    public C0 F1;
    public C1(C0 f1)
    {
        F1 = f1;
    }
}

public class Program
{
    static C1 s_17;
    static C1 s_29 = new C1(new C0());
    static C0 s_45 = new C0();
    public static void Main()
    {
        S1 vr3 = s_45.F5;
        var vr4 = vr3.F3;
        sbyte vr7 = vr4.F2;
        M8(vr7);
    }

    static void M8(short arg0)
    {
        arg0 = -1;
        if (s_29.F1.F5.F3.F4)
        {
            arg0 = s_17.F1.F1;
        }
        else
        {
            try
            {
                var vr0 = new int[]{0};
            }
            finally
            {
                arg0 = arg0++;
            }
        }

        arg0 <<= -1;
        arg0 %= 2178;
        System.Console.WriteLine(arg0);
    }
}