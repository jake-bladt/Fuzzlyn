// Generated by Fuzzlyn on 2018-06-28 11:41:29
// Seed: 2563448413439216902
// Reduced from 191.4 KiB to 0.2 KiB
// Debug: Outputs 177
// Release: Outputs -79
public class Program
{
    static sbyte s_3 = -79;
    static int s_4;
    public static void Main()
    {
        s_4 = (byte)(s_3 / (0L | 1));
        System.Console.WriteLine(s_4);
    }
}
