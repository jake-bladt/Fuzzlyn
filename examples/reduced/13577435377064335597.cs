// Generated by Fuzzlyn v1.1 on 2018-11-21 14:26:49
// Seed: 13577435377064335597
// Reduced from 44.0 KiB to 0.5 KiB in 00:00:58
// Debug: Outputs 0
// Release: Outputs 1
class C0
{
}

class C1
{
}

struct S0
{
    public short F2;
    public C0 F4;
    public C1 F6;
    public S0(short f2): this()
    {
        F2 = f2;
    }
}

public class Program
{
    static S0 s_9;
    public static void Main()
    {
        var vr11 = new S0(1);
        var vr12 = new S0(0);
        M12(s_9, M12(vr11, vr12));
    }

    static ref S0 M12(S0 arg0, S0 arg1)
    {
        int var1 = arg0.F2;
        System.Console.WriteLine(var1);
        return ref s_9;
    }
}
