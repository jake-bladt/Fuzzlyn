// Generated by Fuzzlyn on 2018-06-29 15:20:35
// Seed: 13096420170868269003
// Reduced from 382.1 KiB to 0.4 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
class C1
{
    public ulong F1;
    public ulong F4;
}

public class Program
{
    static C1[,, ] s_22 = new C1[,, ]{{{new C1()}}};
    static bool[] s_57 = new bool[]{true};
    static byte s_77;
    public static void Main()
    {
        var vr44 = (uint)(0 & s_22[0, 0, 0].F1);
        var vr45 = s_57[0];
        M108(vr44);
    }

    static ulong M108(uint arg0)
    {
        s_77 %= 1;
        return s_22[0, 0, 0].F4;
    }
}
