// Generated by Fuzzlyn v1.1 on 2018-09-27 12:02:02
// Seed: 2290666869531557983
// Reduced from 65.9 KiB to 8.2 KiB in 00:07:47
// Debug: Outputs True
// Release: Outputs False
struct S0
{
    public bool F0;
    public long F1;
    public int F2;
    public byte F3;
    public S0(bool f0, long f1): this()
    {
        F0 = f0;
        F1 = f1;
    }
}

struct S1
{
    public S0 F0;
    public uint F4;
}

struct S2
{
    public int F0;
    public short F1;
    public sbyte F2;
    public short F3;
    public S0 F4;
    public S2(S0 f4): this()
    {
        F4 = f4;
    }
}

class C0
{
    public S1 F1;
}

struct S3
{
    public S2 F0;
    public S3(S2 f0): this()
    {
        F0 = f0;
    }
}

class C1
{
    public byte F0;
    public ulong F1;
    public uint F2;
    public uint F3;
    public C1(ulong f1, uint f2)
    {
        F1 = f1;
        F2 = f2;
    }
}

struct S4
{
    public S2 F0;
    public S3 F1;
    public short F2;
    public S4(S2 f0, S3 f1): this()
    {
        F0 = f0;
        F1 = f1;
    }
}

struct S5
{
    public ulong F0;
    public bool F1;
    public S5(ulong f0): this()
    {
        F0 = f0;
    }
}

struct S6
{
    public S4 F0;
    public S3 F2;
    public uint F4;
    public int F6;
}

public class Program
{
    static S6 s_1;
    static S4[] s_3 = new S4[]{new S4(new S2(new S0(true, 0)), new S3(new S2(new S0(false, 0))))};
    static C0 s_10 = new C0();
    static S5[] s_12;
    static S4[] s_13;
    public static void Main()
    {
        var vr4 = s_3[0].F1;
        var vr5 = s_1.F4;
        var vr6 = new S0(true, 0);
        var vr7 = new S1();
        S3 vr8 = vr4;
        uint vr9 = vr5;
        S0 vr10 = vr6;
        S1 vr11 = vr7;
        byte vr12 = default(byte);
        ulong vr13 = default(ulong);
        bool vr14 = default(bool);
        ulong vr15 = default(ulong);
        S4 vr16 = default(S4);
        S3 vr18 = new S3(new S2(new S0(true, 0)));
        System.Console.WriteLine(vr18.F0.F0);
        System.Console.WriteLine(vr18.F0.F1);
        System.Console.WriteLine(vr18.F0.F2);
        System.Console.WriteLine(vr18.F0.F3);
        System.Console.WriteLine(vr18.F0.F4.F0);
        System.Console.WriteLine(vr18.F0.F4.F1);
        System.Console.WriteLine(vr18.F0.F4.F2);
        System.Console.WriteLine(vr18.F0.F4.F3);
        System.Console.WriteLine(vr12);
        try
        {
            System.Console.WriteLine(vr13);
        }
        finally
        {
            vr8.F0 = new S2(new S0(true, 0));
            if (vr10.F0)
            {
                System.Console.WriteLine(0);
                System.Console.WriteLine(vr15);
                bool vr19 = vr8.F0.F4.F0;
                int vr20 = s_1.F6;
                System.Console.WriteLine(vr14);
                System.Console.WriteLine(vr20);
                System.Console.WriteLine(vr19);
            }
            else
            {
                if (vr11.F0.F0)
                {
                    System.Console.WriteLine(vr16.F0.F0);
                    System.Console.WriteLine(vr16.F0.F1);
                    System.Console.WriteLine(vr16.F0.F2);
                    System.Console.WriteLine(vr16.F0.F3);
                    System.Console.WriteLine(vr16.F0.F4.F0);
                    System.Console.WriteLine(vr16.F0.F4.F1);
                    System.Console.WriteLine(vr16.F0.F4.F2);
                    System.Console.WriteLine(vr16.F0.F4.F3);
                    System.Console.WriteLine(vr16.F1.F0.F1);
                    System.Console.WriteLine(vr16.F1.F0.F2);
                    System.Console.WriteLine(vr16.F1.F0.F3);
                    System.Console.WriteLine(vr16.F1.F0.F4.F1);
                    System.Console.WriteLine(vr16.F1.F0.F4.F2);
                    System.Console.WriteLine(vr16.F1.F0.F4.F3);
                }
                else
                {
                    C1[][] vr21 = new C1[][]{new C1[]{new C1(0, 0)}, new C1[]{new C1(0, 0)}, new C1[]{new C1(0, 0)}, new C1[]{new C1(0, 0)}, new C1[]{new C1(0, 0)}, new C1[]{new C1(0, 0)}, new C1[]{new C1(0, 0)}, new C1[]{new C1(0, 0)}, new C1[]{new C1(0, 0)}};
                    S5 vr22 = new S5(0);
                    vr21[0][0].F2 &= 0;
                    C1 vr23 = new C1(0, 0);
                    S4 vr24 = s_1.F0;
                    C1[, ] vr25 = new C1[, ]{{new C1(0, 0), new C1(0, 0), new C1(0, 0), new C1(0, 0), new C1(0, 0)}, {new C1(0, 0), new C1(0, 0), new C1(0, 0), new C1(0, 0), new C1(0, 0)}, {new C1(0, 0), new C1(0, 0), new C1(0, 0), new C1(0, 0), new C1(0, 0)}, {new C1(0, 0), new C1(0, 0), new C1(0, 0), new C1(0, 0), new C1(0, 0)}, {new C1(0, 0), new C1(0, 0), new C1(0, 0), new C1(0, 0), new C1(0, 0)}, {new C1(0, 0), new C1(0, 0), new C1(0, 0), new C1(0, 0), new C1(0, 0)}, {new C1(0, 0), new C1(0, 0), new C1(0, 0), new C1(0, 0), new C1(0, 0)}, {new C1(0, 0), new C1(0, 0), new C1(0, 0), new C1(0, 0), new C1(0, 0)}, {new C1(0, 0), new C1(0, 0), new C1(0, 0), new C1(0, 0), new C1(0, 0)}};
                    System.Console.WriteLine(vr24.F0.F0);
                    System.Console.WriteLine(vr24.F0.F1);
                    System.Console.WriteLine(vr24.F0.F2);
                    System.Console.WriteLine(vr24.F0.F3);
                    System.Console.WriteLine(vr24.F0.F4.F0);
                    System.Console.WriteLine(vr24.F0.F4.F1);
                    System.Console.WriteLine(vr24.F0.F4.F2);
                    System.Console.WriteLine(vr24.F0.F4.F3);
                    System.Console.WriteLine(vr24.F1.F0.F1);
                    System.Console.WriteLine(vr24.F1.F0.F2);
                    System.Console.WriteLine(vr24.F1.F0.F3);
                    System.Console.WriteLine(vr24.F1.F0.F4.F0);
                    System.Console.WriteLine(vr24.F1.F0.F4.F1);
                    System.Console.WriteLine(vr24.F1.F0.F4.F2);
                    System.Console.WriteLine(vr24.F1.F0.F4.F3);
                    System.Console.WriteLine(vr24.F2);
                    System.Console.WriteLine(vr25[0, 0].F0);
                    System.Console.WriteLine(vr25[0, 0].F1);
                    System.Console.WriteLine(vr25[0, 0].F2);
                    System.Console.WriteLine(vr25[0, 0].F3);
                    System.Console.WriteLine(vr21[0][0].F0);
                    System.Console.WriteLine(vr21[0][0].F1);
                    System.Console.WriteLine(vr21[0][0].F2);
                    System.Console.WriteLine(vr21[0][0].F3);
                    System.Console.WriteLine(vr22.F0);
                    System.Console.WriteLine(vr23.F0);
                    System.Console.WriteLine(vr23.F1);
                    System.Console.WriteLine(vr23.F2);
                    System.Console.WriteLine(vr23.F3);
                }
            }

            byte vr27 = default(byte);
            C1 vr26 = new C1(vr27, s_10.F1.F4);
            byte vr28 = default(byte);
            vr10.F3 &= vr28;
            System.Console.WriteLine(vr26.F0);
            System.Console.WriteLine(vr26.F1);
            System.Console.WriteLine(vr26.F2);
            System.Console.WriteLine(vr26.F3);
        }

        if (s_1.F2.F0.F4.F0)
        {
            s_12 = new S5[]{new S5(0), new S5(0), new S5(0), new S5(0), new S5(0), new S5(0), new S5(0), new S5(0), new S5(0)};
        }
        else
        {
            s_13 = new S4[]{new S4(new S2(new S0(true, 0)), new S3(new S2(new S0(false, 0)))), new S4(new S2(new S0(false, 0)), new S3(new S2(new S0(false, 0)))), new S4(new S2(new S0(true, 0)), new S3(new S2(new S0(true, 0)))), new S4(new S2(new S0(false, 0)), new S3(new S2(new S0(false, 0)))), new S4(new S2(new S0(false, 0)), new S3(new S2(new S0(true, 0)))), new S4(new S2(new S0(true, 0)), new S3(new S2(new S0(false, 0)))), new S4(new S2(new S0(true, 0)), new S3(new S2(new S0(false, 0))))};
        }

        System.Console.WriteLine(vr8.F0.F0);
        System.Console.WriteLine(vr8.F0.F1);
        System.Console.WriteLine(vr8.F0.F3);
        System.Console.WriteLine(vr8.F0.F4.F0);
        System.Console.WriteLine(vr8.F0.F4.F1);
        System.Console.WriteLine(vr8.F0.F4.F2);
        System.Console.WriteLine(vr8.F0.F4.F3);
        System.Console.WriteLine(vr9);
        System.Console.WriteLine(vr10.F0);
        System.Console.WriteLine(vr10.F1);
        System.Console.WriteLine(vr10.F2);
        System.Console.WriteLine(vr10.F3);
        System.Console.WriteLine(vr11.F0.F0);
    }
}