// Generated by Fuzzlyn v1.1 on 2018-10-04 00:41:37
// Seed: 2279104689160833469
// Reduced from 4.0 KiB to 0.2 KiB in 00:00:13
// Debug: Runs successfully
// Release: Throws 'System.DivideByZeroException'
public class Program
{
    public static void Main()
    {
        ushort[] vr2 = new ushort[]{13860};
        ushort vr3 = vr2[0];
        bool vr4 = ((0 % (1 % vr2[0])) / (sbyte)(-1 / ((0 % vr3) | 1))) < 0;
    }
}