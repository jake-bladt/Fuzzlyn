// Generated by Fuzzlyn on 2018-06-25 14:15:02
// Seed: 3334199239482480368
// Reduced from 22.6 KiB to 0.3 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
struct S0
{
    public uint F1;
    public int F5;
}

public class Program
{
    static S0[][, ] s_3 = new S0[][, ]{new S0[, ]{{new S0()}}};
    public static void Main()
    {
        var vr28 = s_3[0][0, 0].F5--;
        var vr30 = s_3[0][0, 0].F1 & 0;
        var vr32 = vr30 % s_3[0][0, 0].F5;
    }
}