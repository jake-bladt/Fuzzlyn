// Generated by Fuzzlyn on 2018-06-25 14:32:48
// Seed: 6102990521617317853
// Reduced from 86.9 KiB to 0.2 KiB
// Debug: Outputs 129
// Release: Outputs -127
public class Program
{
    static sbyte s_9 = -127;
    public static void Main()
    {
        var vr7 = (byte)(0U | s_9);
        System.Console.WriteLine((int)vr7);
    }
}
