// Generated by Fuzzlyn on 2018-06-25 13:59:14
// Seed: 17894827521523611055
// Reduced from 9.3 KiB to 0.2 KiB
// Debug: Outputs 32778
// Release: Outputs 4294934538
public class Program
{
    static short s_2 = -32768;
    public static void Main()
    {
        char vr9 = (char)(10U | s_2);
        uint vr11 = vr9;
        System.Console.WriteLine(vr11);
    }
}
