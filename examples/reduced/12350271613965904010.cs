// Generated by Fuzzlyn on 2018-06-25 13:20:28
// Seed: 12350271613965904010
// Reduced from 102.7 KiB to 0.4 KiB
// Debug: Outputs 65436
// Release: Outputs 4294967196
class C0
{
    public ulong F1;
    public ulong F5;
    public C0(ulong f1)
    {
        F1 = f1;
    }
}

public class Program
{
    static C0[] s_23 = new C0[]{new C0(11266750174733769116UL)};
    public static void Main()
    {
        var vr8 = s_23[0];
        vr8.F5 = (ushort)(sbyte)(vr8.F1 ^ 0);
        System.Console.WriteLine(vr8.F5);
    }
}
