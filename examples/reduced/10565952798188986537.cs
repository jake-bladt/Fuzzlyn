// Generated by Fuzzlyn v1.1 on 2018-09-30 12:06:04
// Seed: 10565952798188986537
// Reduced from 440.1 KiB to 0.7 KiB in 00:08:43
// Debug: Prints 2 line(s)
// Release: Prints 1 line(s)
class C0
{
    public int F0;
    public int F9;
}

struct S0
{
    public ulong F1;
    public C0 F2;
    public bool F5;
    public S0(C0 f2, bool f5): this()
    {
        F2 = f2;
        F5 = f5;
    }
}

public class Program
{
    static S0 s_13;
    static S0 s_56;
    public static void Main()
    {
        var vr3 = new S0(new C0(), true);
        var vr4 = new S0(new C0(), true);
        M27(vr3, M27(vr4, s_56));
    }

    static ref S0 M27(S0 arg0, S0 arg1)
    {
        long var15 = default(long);
        if (arg0.F5)
        {
            System.Console.WriteLine(var15);
        }

        arg0.F5 = false;
        arg0.F2.F9 = arg0.F2.F0;
        return ref s_13;
    }
}
