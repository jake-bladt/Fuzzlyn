// Generated by Fuzzlyn on 2018-07-19 00:51:48
// Seed: 5767583187087933934
// Reduced from 38.8 KiB to 0.3 KiB
// Debug: Outputs 65535
// Release: Outputs -1
public class Program
{
    static sbyte s_3 = -1;
    public static void Main()
    {
        var vr23 = M4();
        int vr24 = vr23;
        System.Console.WriteLine(vr24);
    }

    static char M4()
    {
        return (char)(0 ^ s_3);
    }
}
