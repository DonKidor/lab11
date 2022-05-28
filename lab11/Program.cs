

public class Programm
{
    public static void Main()
    {
        long res = HW1.QueueTime(new int[] {5,3,4}, 1);
        Console.WriteLine(res);
        res = HW1.QueueTime(new int[] { 10, 2, 3, 3 }, 2);
        Console.WriteLine(res);
        res = HW1.QueueTime(new int[] {2,3,10},2);
        Console.WriteLine(res);
    }
}