// Generated by Fuzzlyn on 2018-06-25 14:13:31
// Seed: 3214748945266160410
// Reduced from 122.3 KiB to 0.3 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
struct S0
{
    public char F0;
    public ushort F1;
}

public class Program
{
    static S0[][, ] s_2 = new S0[][, ]{new S0[, ]{{new S0()}}};
    public static void Main()
    {
        bool vr8 = (0 & s_2[0][0, 0].F1) >= 0;
        if (vr8)
        {
            s_2[0][0, 0].F0--;
        }
    }
}
