// Generated by Fuzzlyn on 2018-06-24 15:51:24
// Seed: 15656896518564042085
// Reduced from 143.7 KiB to 0.2 KiB
// Debug: Outputs 147
// Release: Outputs -109
public class Program
{
    static sbyte s_5 = -109;
    public static void Main()
    {
        byte vr10 = (byte)(s_5 | 1U);
        System.Console.WriteLine((int)vr10);
    }
}
