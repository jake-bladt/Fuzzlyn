// Generated by Fuzzlyn on 2018-06-25 14:32:27
// Seed: 597067797595363130
// Reduced from 124.0 KiB to 0.3 KiB
// Debug: Outputs 65535
// Release: Outputs 4294967295
public class Program
{
    static short s_5 = -1;
    static long[, ] s_8 = new long[, ]{{0}};
    static short s_10;
    public static void Main()
    {
        s_10 = s_5;
        ushort vr34 = (ushort)(s_8[0, 0] ^ s_10);
        ulong vr36 = vr34;
        System.Console.WriteLine(vr36);
    }
}
