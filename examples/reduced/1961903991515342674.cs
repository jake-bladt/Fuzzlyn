// Generated by Fuzzlyn v1.1 on 2018-10-04 08:22:48
// Seed: 1961903991515342674
// Reduced from 343.6 KiB to 1.1 KiB in 00:09:12
// Debug: Outputs 0
// Release: Outputs 1
struct S0
{
    public short F1;
    public uint F4;
    public ulong F5;
    public sbyte F6;
    public S0(short f1): this()
    {
        F1 = f1;
    }
}

struct S1
{
    public S0 F0;
    public S1(S0 f0): this()
    {
        F0 = f0;
    }
}

struct S2
{
    public int F7;
}

public class Program
{
    static S1 s_18;
    static uint s_20;
    static S1 s_26;
    static S2 s_32;
    static S2 s_50;
    public static void Main()
    {
        S0 vr8 = default(S0);
        S1 vr9 = new S1(new S0(1));
        var vr6 = new short[]{1};
        ushort vr7 = (ushort)M9(vr8, M42(ref s_32.F7, ref M42(ref M64(vr9, vr6), ref s_26)));
    }

    static uint M9(S0 arg0, S1 arg1)
    {
        System.Console.WriteLine(arg0.F1);
        return arg0.F4;
    }

    static ref S1 M42(ref int arg1, ref S1 arg2)
    {
        arg2.F0.F6 = arg2.F0.F6++;
        return ref s_18;
    }

    static ref int M64(S1 arg0, short[] arg1)
    {
        bool vr15 = s_20 == arg1[0];
        bool vr19 = vr15;
        return ref s_50.F7;
    }
}