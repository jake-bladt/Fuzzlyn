// Generated by Fuzzlyn v1.1 on 2018-09-25 02:35:13
// Seed: 12170269816090736534
// Reduced from 163.4 KiB to 0.5 KiB in 00:01:31
// Debug: Outputs -2
// Release: Outputs 2057
class C0
{
    public short F2;
}

public class Program
{
    static short[][] s_6 = new short[][]{new short[]{0}};
    static C0 s_42 = new C0();
    public static void Main()
    {
        var vr1 = s_42.F2;
        M1(vr1);
    }

    static void M1(short arg0)
    {
        try
        {
            --arg0;
        }
        finally
        {
            s_6[0][0] = arg0--;
            arg0 %= 21159;
        }

        System.Console.WriteLine(arg0);
    }
}