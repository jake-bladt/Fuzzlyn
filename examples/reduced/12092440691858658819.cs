// Generated by Fuzzlyn v1.1 on 2018-08-19 08:32:26
// Seed: 12092440691858658819
// Reduced from 4.8 KiB to 0.2 KiB
// Debug: Outputs 13
// Release: Outputs 12
public class Program
{
    public static void Main()
    {
        byte[] vr0 = new byte[]{246};
        ushort vr1 = (ushort)((5705059232137804967L % (ushort)(1L + vr0[0])) | 1);
        System.Console.WriteLine(vr1);
    }
}