// Generated by Fuzzlyn on 2018-06-25 15:04:31
// Seed: 9471702060375167630
// Reduced from 14.5 KiB to 0.2 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static char[, ] s_4 = new char[, ]{{'B'}};
    public static void Main()
    {
        ulong vr0 = (ulong)((0 / ((0 & s_4[0, 0]) | 1)) | s_4[0, 0]);
    }
}
