// Generated by Fuzzlyn v1.1 on 2018-08-12 05:44:27
// Seed: 15091836866434651165
// Reduced from 69.0 KiB to 0.5 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
struct S0
{
    public int F0;
    public bool F1;
    public byte F2;
    public long F3;
    public uint F4;
    public S0(byte f2): this()
    {
        F2 = f2;
    }
}

public class Program
{
    static ushort[] s_1;
    public static void Main()
    {
        var vr55 = new short[][, ]{new short[, ]{{0}}};
        var vr59 = new S0((byte)(0 & vr55[0][0, 0]));
        var vr60 = vr55[0][0, 0];
        var vr69 = vr59.F0;
        M3(vr69);
    }

    static ref ushort[] M3(int arg0)
    {
        return ref s_1;
    }
}