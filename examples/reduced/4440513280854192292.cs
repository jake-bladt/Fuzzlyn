// Generated by Fuzzlyn on 2018-07-16 00:58:38
// Seed: 4440513280854192292
// Reduced from 41.5 KiB to 0.3 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static byte[, ] s_1 = new byte[, ]{{0}};
    static ushort s_3 = 65535;
    public static void Main()
    {
        bool vr3 = (s_1[0, 0] & 0) != s_3;
        if (vr3)
        {
            s_1 = s_1;
        }

        System.Console.WriteLine(s_1[0, 0]);
    }
}
