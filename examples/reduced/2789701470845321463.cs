// Generated by Fuzzlyn on 2018-06-20 14:09:26
// Seed: 2789701470845321463
// Reduced from 232.7 KiB to 0.4 KiB
// Debug: Outputs -28
// Release: Outputs 0
struct S0
{
    public sbyte F1;
    public short F2;
    public bool F3;
}

struct S1
{
    public S0 F7;
    public sbyte F8;
    public S1(sbyte f8): this()
    {
        F8 = f8;
    }
}

public class Program
{
    static S1 s_35 = new S1(-28);
    public static void Main()
    {
        s_35.F7 = M18();
        System.Console.WriteLine(s_35.F8);
    }

    static S0 M18()
    {
        return new S0();
    }
}
