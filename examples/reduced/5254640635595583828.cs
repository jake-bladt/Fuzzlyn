// Generated by Fuzzlyn on 2018-06-25 14:28:04
// Seed: 5254640635595583828
// Reduced from 144.9 KiB to 0.4 KiB
// Debug: Outputs 65516
// Release: Outputs -20
class C0
{
    public ushort F4;
    public C0(ushort f4)
    {
        F4 = f4;
    }
}

public class Program
{
    static C0[] s_1 = new C0[]{new C0(2540)};
    public static void Main()
    {
        var vr17 = (ushort)(0 ^ (sbyte)M15());
        System.Console.WriteLine((int)vr17);
    }

    static ushort M15()
    {
        return s_1[0].F4;
    }
}
