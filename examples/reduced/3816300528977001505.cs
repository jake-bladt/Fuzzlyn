// Generated by Fuzzlyn on 2018-06-25 14:19:19
// Seed: 3816300528977001505
// Reduced from 189.3 KiB to 0.2 KiB
// Debug: Outputs False
// Release: Outputs True
public class Program
{
    static uint s_23 = 1232329959U;
    static short s_32 = -10;
    public static void Main()
    {
        bool vr10 = (ushort)(1L | s_32) > s_23;
        System.Console.WriteLine(vr10);
    }
}
