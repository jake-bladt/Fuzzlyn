// Generated by Fuzzlyn v1.1 on 2018-09-18 14:19:35
// Seed: 4934697782632969822
// Reduced from 88.5 KiB to 0.9 KiB in 00:01:44
// Debug: Outputs -1
// Release: Outputs 15623
class C0
{
    public sbyte F0;
    public short F1;
    public sbyte F2;
    public uint F4;
    public byte F5;
    public C0(short f1)
    {
        F1 = f1;
    }
}

public class Program
{
    static C0 s_3 = new C0(1);
    static C0[, ] s_9 = new C0[, ]{{new C0(0)}};
    static short s_15;
    public static void Main()
    {
        M14(s_15);
    }

    static void M14(short arg1)
    {
        s_9[0, 0] = new C0(-1);
        try
        {
            arg1 = s_9[0, 0].F1;
            arg1 %= -24956;
        }
        finally
        {
            System.Console.WriteLine(s_3.F0);
            System.Console.WriteLine(s_3.F1);
            System.Console.WriteLine(s_3.F2);
            System.Console.WriteLine(s_3.F4);
            System.Console.WriteLine(s_3.F5);
        }

        System.Console.WriteLine(arg1);
    }
}