// Generated by Fuzzlyn on 2018-07-01 11:18:42
// Seed: 9514066938007486112
// Reduced from 84.2 KiB to 0.2 KiB
// Debug: Outputs 32769
// Release: Outputs -32767
public class Program
{
    static short s_3 = -32768;
    public static void Main()
    {
        char vr12 = (char)(1U | s_3);
        System.Console.WriteLine((int)vr12);
    }
}
