// Generated by Fuzzlyn v1.1 on 2018-11-22 16:22:23
// Seed: 16734379805192318467
// Reduced from 132.6 KiB to 0.5 KiB in 00:02:15
// Debug: Outputs 0
// Release: Outputs 65535
struct S0
{
    public ulong F0;
    public short F1;
    public ulong F2;
}

public class Program
{
    static short[] s_2 = new short[]{0};
    static S0 s_7;
    public static void Main()
    {
        var vr12 = new S0();
        var vr13 = new S0();
        var vr14 = new S0();
        M14(vr12, M14(vr13, vr14));
        ushort vr15 = (ushort)s_2[0];
        System.Console.WriteLine(vr15);
    }

    static ref S0 M14(S0 arg0, S0 arg1)
    {
        s_2[0] = arg0.F1--;
        return ref s_7;
    }
}
