// Generated by Fuzzlyn on 2018-06-23 03:13:29
// Seed: 16669168451615620797
// Reduced from 59.7 KiB to 0.2 KiB
// Debug: Outputs 32768
// Release: Outputs -32768
public class Program
{
    static short s_4 = 32766;
    public static void Main()
    {
        var vr30 = s_4++;
        var vr39 = s_4++;
        char vr36 = (char)(0L ^ s_4);
        System.Console.WriteLine((int)vr36);
    }
}
