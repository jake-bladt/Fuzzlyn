// Generated by Fuzzlyn on 2018-07-06 01:05:01
// Seed: 16206941620464847476
// Reduced from 27.4 KiB to 0.2 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static int[, ] s_1 = new int[, ]{{0}};
    public static void Main()
    {
        bool vr1 = (0 / ((0 & s_1[0, 0]) | 1)) > s_1[0, 0];
    }
}
