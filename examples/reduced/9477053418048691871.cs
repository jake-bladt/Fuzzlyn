// Generated by Fuzzlyn on 2018-06-23 22:31:58
// Seed: 9477053418048691871
// Reduced from 27.2 KiB to 0.2 KiB
// Debug: Outputs 65535
// Release: Outputs 4294967295
public class Program
{
    static long s_5 = 9223372036854775807L;
    public static void Main()
    {
        s_5 = (char)(sbyte)(0 | s_5);
        System.Console.WriteLine(s_5);
    }
}
