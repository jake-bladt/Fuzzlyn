// Generated by Fuzzlyn on 2018-06-25 13:08:18
// Seed: 11206766282584507575
// Reduced from 16.2 KiB to 0.3 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static long s_1 = 887303721353470405L;
    static long[, ] s_2 = new long[, ]{{0}};
    public static void Main()
    {
        bool vr5 = s_1 > (0 & s_2[0, 0]);
        if (vr5)
        {
            var vr6 = s_2[0, 0];
        }
    }
}
