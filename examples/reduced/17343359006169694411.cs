// Generated by Fuzzlyn v1.1 on 2018-08-12 17:36:31
// Seed: 17343359006169694411
// Reduced from 44.4 KiB to 0.2 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static long[, ] s_4 = new long[, ]{{0}};
    public static void Main()
    {
        var vr23 = 0 / ((0 & s_4[0, 0]) | 1);
        long vr20 = s_4[0, 0];
    }
}