// Generated by Fuzzlyn v1.1 on 2018-08-27 12:10:53
// Seed: 3251817535003112283
// Reduced from 173.7 KiB to 0.9 KiB in 00:04:27
// Debug: Prints 1 line(s)
// Release: Prints 2 line(s)
class C0
{
    public int F0;
    public bool F3;
    public C0(bool f3)
    {
        F3 = f3;
    }
}

class C1
{
    public C0 F0;
    public C1(C0 f0)
    {
        F0 = f0;
    }
}

struct S0
{
    public ushort F0;
    public C1 F4;
    public long F5;
    public S0(C1 f4): this()
    {
        F4 = f4;
    }
}

public class Program
{
    static S0 s_24 = new S0(new C1(new C0(true)));
    static S0 s_27 = new S0(new C1(new C0(true)));
    public static void Main()
    {
        S0 vr0 = new S0(new C1(new C0(false)));
        M36(vr0, M40(s_24));
    }

    static void M36(S0 arg0, S0 arg1)
    {
        if (arg0.F4.F0.F3)
        {
            C0 var0 = arg1.F4.F0;
            System.Console.WriteLine(var0.F0);
        }
    }

    static ref S0 M40(S0 arg0)
    {
        System.Console.WriteLine(arg0.F0);
        return ref s_27;
    }
}
