// Generated by Fuzzlyn on 2018-06-29 07:31:54
// Seed: 11716030451107381098
// Reduced from 27.0 KiB to 0.2 KiB
// Debug: Throws 'System.OverflowException'
// Release: Runs successfully
public class Program
{
    static sbyte s_1;
    public static void Main()
    {
        var vr15 = 0 % ((0 & (-9223372036854775808L % (sbyte)((s_1 ^ 9223372036854775806L) | 1))) | 1);
    }
}
