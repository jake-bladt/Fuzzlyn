// Generated by Fuzzlyn on 2018-06-25 14:57:28
// Seed: 849890360409585929
// Reduced from 19.1 KiB to 0.3 KiB
// Debug: Outputs 0
// Release: Outputs -12246
public class Program
{
    public static void Main()
    {
        var vr16 = new short[]{-12246};
        uint vr18 = default(uint);
        bool vr20 = (char)(vr16[0] / (vr18 | 1)) >= 0;
        if (vr20)
        {
            vr16[0] = 0;
        }

        System.Console.WriteLine(vr16[0]);
    }
}
