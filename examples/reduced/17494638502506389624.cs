// Generated by Fuzzlyn v1.1 on 2018-08-20 21:21:33
// Seed: 17494638502506389624
// Reduced from 251.6 KiB to 0.5 KiB in 00:06:24
// Debug: Outputs 0
// Release: Outputs 1
struct S0
{
    public sbyte F0;
    public short F3;
    public byte F5;
    public S0(short f3): this()
    {
        F3 = f3;
    }
}

public class Program
{
    static S0[] s_3 = new S0[]{new S0(1)};
    static S0[] s_9 = new S0[]{new S0(0)};
    public static void Main()
    {
        M14() = s_3[0];
        short vr6 = s_9[0].F3;
        System.Console.WriteLine(vr6);
    }

    static ref S0 M14()
    {
        s_3 = new S0[]{new S0(0)};
        return ref s_9[0];
    }
}