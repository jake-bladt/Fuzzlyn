// Generated by Fuzzlyn on 2018-06-25 14:08:01
// Seed: 2404866603935356354
// Reduced from 26.1 KiB to 0.2 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static sbyte[, ] s_1 = new sbyte[, ]{{0}};
    public static void Main()
    {
        short vr14 = (byte)((s_1[0, 0] & 0) & s_1[0, 0]--);
        System.Console.WriteLine(vr14);
    }
}