// Generated by Fuzzlyn v1.1 on 2018-08-14 02:14:37
// Seed: 3319619721867169357
// Reduced from 115.5 KiB to 0.5 KiB in 00:02:19
// Debug: Outputs 1
// Release: Outputs 0
struct S0
{
    public byte F6;
    public ulong F7;
    public S0(byte f6): this()
    {
        F6 = f6;
    }
}

public class Program
{
    static S0[] s_4 = new S0[]{new S0(0)};
    public static void Main()
    {
        M14(ref s_4) = s_4[0];
        byte vr13 = s_4[0].F6;
        System.Console.WriteLine(vr13);
    }

    static ref S0 M14(ref S0[] arg1)
    {
        arg1 = new S0[]{new S0(1)};
        return ref arg1[0];
    }
}