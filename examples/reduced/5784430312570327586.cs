// Generated by Fuzzlyn on 2018-07-29 10:27:31
// Seed: 5784430312570327586
// Reduced from 54.5 KiB to 0.3 KiB
// Debug: Outputs 255
// Release: Outputs 2147483647
public class Program
{
    static int[] s_1 = new int[]{0};
    public static void Main()
    {
        var vr8 = new int[]{0};
        vr8[0] = 2147483647;
        s_1[0] = vr8[0];
        var vr10 = (byte)s_1[0];
        long vr12 = vr10;
        System.Console.WriteLine(vr12);
    }
}
