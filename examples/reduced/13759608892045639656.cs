// Generated by Fuzzlyn v1.1 on 2018-08-04 19:53:09
// Seed: 13759608892045639656
// Reduced from 192.0 KiB to 0.7 KiB
// Debug: Outputs 0
// Release: Outputs 65534
struct S2
{
    public long F2;
}

struct S3
{
    public bool F0;
    public long F2;
    public S3(long f2): this()
    {
        F2 = f2;
    }
}

public class Program
{
    static S3 s_1;
    static S3[] s_2 = new S3[]{new S3(9223372036854775806L)};
    public static void Main()
    {
        M3() = s_2[0];
        S2 vr43;
        vr43.F2 = s_1.F2;
        M16(ref vr43.F2);
    }

    static ref S3 M3()
    {
        s_2 = new S3[]{new S3(0)};
        return ref s_1;
    }

    static ushort M16(ref long arg1)
    {
        ushort var0 = (ushort)arg1;
        System.Console.WriteLine(var0);
        return 0;
    }
}
