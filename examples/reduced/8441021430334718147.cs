// Generated by Fuzzlyn on 2018-06-25 14:55:13
// Seed: 8441021430334718147
// Reduced from 114.6 KiB to 0.4 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
struct S0
{
    public char F8;
    public S0(char f8): this()
    {
        F8 = f8;
    }
}

struct S2
{
    public uint F4;
}

public class Program
{
    static S0 s_12 = new S0('Z');
    static S2[, ] s_28 = new S2[, ]{{new S2()}};
    public static void Main()
    {
        char vr3 = (char)((s_28[0, 0].F4 & 0) % s_12.F8);
    }
}