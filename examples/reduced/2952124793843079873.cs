// Generated by Fuzzlyn v1.1 on 2018-09-23 18:40:33
// Seed: 2952124793843079873
// Reduced from 7.9 KiB to 1.0 KiB in 00:00:25
// Debug: Outputs 1
// Release: Outputs -1
public class Program
{
    static long s_3 = 7849739773407023944L;
    public static void Main()
    {
        var vr2 = (sbyte)s_3;
        M7(vr2);
    }

    static void M7(sbyte arg1)
    {
        short[] var5 = default(short[]);
        try
        {
            arg1 += arg1;
            arg1 /= -92;
        }
        finally
        {
            if (false == M8())
            {
                M9();
            }
            else
            {
                byte[] var4 = new byte[]{0, 0, 0, 0, 0, 0, 0, 1, 1};
                byte var3 = 0;
                System.Console.WriteLine(var3);
                System.Console.WriteLine(var5[0]);
            }

            if (arg1 == 0)
            {
                M9();
                bool vr0 = M8();
            }
        }

        System.Console.WriteLine(arg1);
    }

    static bool M8()
    {
        return default(bool);
    }

    static ushort M9()
    {
        return default(ushort);
    }
}