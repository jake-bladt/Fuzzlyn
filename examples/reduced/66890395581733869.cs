// Generated by Fuzzlyn on 2018-07-05 20:23:42
// Seed: 66890395581733869
// Reduced from 22.3 KiB to 0.3 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static uint[][, ] s_1 = new uint[][, ]{new uint[, ]{{0}}};
    public static void Main()
    {
        int vr5 = (0 & (sbyte)s_1[0][0, 0]) + M7(s_1[0][0, 0]);
        System.Console.WriteLine(vr5);
    }

    static char M7(uint arg0)
    {
        return 'Y';
    }
}
