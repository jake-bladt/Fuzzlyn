// Generated by Fuzzlyn v1.1 on 2018-08-18 19:19:20
// Seed: 7266825481987487911
// Reduced from 194.9 KiB to 0.2 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static sbyte[, ] s_1 = new sbyte[, ]{{0}};
    public static void Main()
    {
        ushort vr4 = (ushort)((0 & s_1[0, 0]) % (s_1[0, 0] | 1));
    }
}
