// Generated by Fuzzlyn on 2018-07-21 20:12:02
// Seed: 8402448599250815627
// Reduced from 1.8 KiB to 0.3 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static char[, ] s_1 = new char[, ]{{'-'}};
    public static void Main()
    {
        var vr1 = (char)(0 & s_1[0, 0]);
        M1(vr1, s_1);
    }

    static char[][] M1(char arg0, char[, ] arg1)
    {
        arg1[0, 0] = (char)0;
        return new char[][]{new char[]{'e'}};
    }
}
