// Generated by Fuzzlyn on 2018-08-01 12:39:14
// Seed: 3619338253466972029
// Reduced from 17.2 KiB to 0.2 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static long[,, ] s_1 = new long[,, ]{{{0}}};
    public static void Main()
    {
        ushort vr1 = (ushort)(0 & s_1[0, 0, 0]);
        s_1[0, 0, 0] = 0;
        System.Console.WriteLine(vr1);
    }
}
