// Generated by Fuzzlyn on 2018-06-25 22:12:35
// Seed: 5253375114928451758
// Reduced from 9.0 KiB to 0.2 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static char[, ] s_1 = new char[, ]{{'a'}};
    public static void Main()
    {
        sbyte vr3 = (sbyte)((0 & s_1[0, 0]) / s_1[0, 0]);
    }
}
