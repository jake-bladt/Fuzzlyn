// Generated by Fuzzlyn v1.1 on 2018-09-03 05:15:25
// Seed: 16284107782669280685
// Reduced from 485.6 KiB to 0.8 KiB in 00:10:43
// Debug: Outputs -1
// Release: Outputs 1
class C0
{
    public short F2;
    public C0(short f2)
    {
        F2 = f2;
    }
}

public class Program
{
    static C0 s_9;
    static C0 s_22 = new C0(-1);
    static C0[][][] s_41 = new C0[][][]{new C0[][]{new C0[]{new C0(1)}}};
    public static void Main()
    {
        var vr2 = M73(0);
    }

    static int M73(short arg0)
    {
        bool var9 = default(bool);
        arg0 = s_22.F2;
        arg0 %= (-32768 | 1);
        try
        {
            C0 vr6 = s_41[0][0][0];
        }
        finally
        {
            try
            {
                s_9 = s_9;
            }
            finally
            {
                System.Console.WriteLine(var9);
            }
        }

        System.Console.WriteLine(arg0);
        return 0;
    }
}