// Generated by Fuzzlyn v1.1 on 2018-11-26 14:04:22
// Seed: 7574186416331542162
// Reduced from 223.4 KiB to 0.6 KiB in 00:03:01
// Debug: Outputs 1
// Release: Outputs 0
struct S0
{
    public long F0;
    public ushort F2;
    public long F5;
    public S0(ushort f2): this()
    {
        F2 = f2;
    }
}

struct S1
{
    public S0 F3;
    public ushort F4;
}

public class Program
{
    static S0 s_2 = new S0(1);
    static S1 s_7;
    public static void Main()
    {
        M3(s_2, M13(s_2));
    }

    static void M3(S0 arg0, S1 arg1)
    {
        System.Console.WriteLine(arg0.F2);
    }

    static ref S1 M13(S0 arg1)
    {
        arg1.F2 = s_7.F4;
        System.Console.WriteLine(arg1.F0);
        return ref s_7;
    }
}