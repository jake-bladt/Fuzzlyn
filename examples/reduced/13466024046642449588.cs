// Generated by Fuzzlyn v1.1 on 2018-08-13 00:25:17
// Seed: 13466024046642449588
// Reduced from 2.7 KiB to 0.2 KiB
// Debug: Outputs 0
// Release: Outputs 255
public class Program
{
    public static void Main()
    {
        byte[] vr6 = new byte[]{255};
        vr6[0] %= (byte)(vr6[0]-- | 1);
        vr6[0] = vr6[0];
        System.Console.WriteLine(vr6[0]);
    }
}