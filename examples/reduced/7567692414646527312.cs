// Generated by Fuzzlyn on 2018-06-21 07:34:06
// Seed: 7567692414646527312
// Reduced from 19.0 KiB to 0.4 KiB
// Debug: Outputs 2
// Release: Outputs 0
struct S0
{
    public char F0;
    public ushort F1;
    public byte F2;
}

struct S1
{
    public S0 F3;
    public byte F4;
    public S1(byte f4): this()
    {
        F4 = f4;
    }
}

public class Program
{
    static S1[] s_4 = new S1[]{new S1(2)};
    public static void Main()
    {
        s_4[0].F3 = M2();
        System.Console.WriteLine(s_4[0].F4);
    }

    static S0 M2()
    {
        return new S0();
    }
}
