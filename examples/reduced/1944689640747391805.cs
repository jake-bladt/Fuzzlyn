// Generated by Fuzzlyn on 2018-07-10 10:24:39
// Seed: 1944689640747391805
// Reduced from 64.0 KiB to 0.2 KiB
// Debug: Outputs 196
// Release: Outputs 4294967236
public class Program
{
    public static void Main()
    {
        sbyte[] vr9 = new sbyte[]{-60};
        byte vr10 = (byte)(vr9[0] ^ 0U);
        long vr12 = vr10;
        System.Console.WriteLine(vr12);
    }
}
