// Generated by Fuzzlyn on 2018-06-25 13:54:54
// Seed: 17394116789682224815
// Reduced from 138.7 KiB to 0.4 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static byte[][, ] s_1 = new byte[][, ]{new byte[, ]{{0}}};
    static char s_4;
    static short s_5;
    public static void Main()
    {
        int vr26 = s_1[0][0, 0] & 0;
        uint vr27 = s_1[0][0, 0];
        bool vr28 = vr26 <= s_4;
        if (vr28)
        {
            s_5 = 0;
        }
        else
        {
        }
    }
}
