// Generated by Fuzzlyn v1.1 on 2018-11-15 08:22:42
// Seed: 9930138466607234168
// Reduced from 169.6 KiB to 0.9 KiB in 00:02:22
// Debug: Prints 2 line(s)
// Release: Prints 1 line(s)
class C0
{
    public bool F0;
    public bool F2;
}

struct S1
{
    public short F1;
    public bool F2;
    public byte F4;
    public sbyte F5;
    public int F6;
    public C0 F7;
    public S1(bool f2, C0 f7): this()
    {
        F2 = f2;
        F7 = f7;
    }
}

public class Program
{
    static short[] s_7;
    static S1 s_10;
    public static void Main()
    {
        var vr6 = new S1(true, new C0());
        var vr10 = new S1(true, new C0());
        var vr11 = new S1(false, new C0());
        M20(vr6, M20(vr10, vr11));
    }

    static ref S1 M20(S1 arg0, S1 arg1)
    {
        if (arg0.F2)
        {
            arg0.F2 = arg0.F7.F0;
            try
            {
                s_7 = new short[]{0};
            }
            finally
            {
                bool var0 = arg0.F7.F2;
                System.Console.WriteLine(var0);
            }
        }

        return ref s_10;
    }
}