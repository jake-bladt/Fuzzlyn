// Generated by Fuzzlyn v1.1 on 2018-09-07 11:13:25
// Seed: 6821017559046753622
// Reduced from 208.7 KiB to 0.8 KiB in 00:05:07
// Debug: Outputs 0
// Release: Outputs -81
public class Program
{
    static ushort[] s_15 = new ushort[]{0};
    static ulong s_31;
    static bool s_36;
    public static void Main()
    {
        M80(-1);
        short vr8 = (short)s_31;
        System.Console.WriteLine(vr8);
    }

    static void M80(short arg0)
    {
        ushort var0 = default(ushort);
        try
        {
            s_15[0] = var0;
        }
        finally
        {
            var vr2 = new sbyte[][]{new sbyte[]{0}, new sbyte[]{0}, new sbyte[]{1}, new sbyte[]{0}, new sbyte[]{0}, new sbyte[]{1}, new sbyte[]{0}, new sbyte[]{0}, new sbyte[]{0}};
            M81();
        }

        short vr14 = (short)s_31;
        arg0 *= vr14;
        s_31 = (ulong)(arg0 % 247);
    }

    static ref bool M81()
    {
        return ref s_36;
    }
}
