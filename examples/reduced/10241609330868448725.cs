// Generated by Fuzzlyn v1.1 on 2018-10-02 00:56:13
// Seed: 10241609330868448725
// Reduced from 90.5 KiB to 0.9 KiB in 00:04:16
// Debug: Outputs 1
// Release: Outputs 0
public class Program
{
    static int s_1;
    static byte s_2;
    static int s_3;
    static ushort s_8;
    static ushort[] s_19 = new ushort[]{1};
    static sbyte s_20;
    static short[, ][] s_28 = new short[, ][]{{new short[]{0}}};
    public static void Main()
    {
        s_1 = -1;
        ulong vr43 = (ulong)s_1;
        int vr42 = (int)vr43;
        var vr40 = (short)vr42;
        bool vr41 = M21(vr40);
        System.Console.WriteLine(s_3);
    }

    static bool M21(short arg0)
    {
        s_2 = (byte)arg0++;
        if (1 > (ulong)(4617 * arg0))
        {
            s_1 <<= s_3++;
        }

        try
        {
            M25();
        }
        finally
        {
            s_28[0, 0][0] = arg0;
        }

        return s_19[0] < s_20;
    }

    static ref ushort M25()
    {
        return ref s_8;
    }
}