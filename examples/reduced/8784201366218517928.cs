// Generated by Fuzzlyn on 2018-06-25 15:01:49
// Seed: 8784201366218517928
// Reduced from 40.0 KiB to 0.3 KiB
// Debug: Outputs 199
// Release: Outputs -57
struct S0
{
    public sbyte F0;
    public S0(sbyte f0): this()
    {
        F0 = f0;
    }
}

public class Program
{
    static S0 s_1;
    public static void Main()
    {
        s_1 = new S0(-58);
        var vr27 = (byte)(s_1.F0 ^ 1U);
        System.Console.WriteLine((int)vr27);
    }
}
