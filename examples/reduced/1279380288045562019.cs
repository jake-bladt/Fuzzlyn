// Generated by Fuzzlyn on 2018-06-21 19:35:14
// Seed: 1279380288045562019
// Reduced from 52.3 KiB to 0.2 KiB
// Debug: Outputs -12657
// Release: Outputs 1
public class Program
{
    public static void Main()
    {
        var vr12 = new int[]{0};
        vr12[0] = -461271461;
        var vr14 = vr12[0] / (char)vr12[0];
        System.Console.WriteLine((int)vr14);
    }
}
