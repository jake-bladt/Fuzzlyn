// Generated by Fuzzlyn on 2018-06-18 15:36:38
// Seed: 6612228551356941005
// Reduced from 71.5 KiB to 0.2 KiB
// Debug: Outputs 1415926905
// Release: Outputs 2366919801
public class Program
{
    public static void Main()
    {
        uint[] vr45 = new uint[]{1435745803U};
        vr45[0] = ((ushort)vr45[0] * vr45[0]);
        System.Console.WriteLine(vr45[0]);
    }
}
