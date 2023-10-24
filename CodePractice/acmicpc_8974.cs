// - 8974 희주의 수학시험

namespace ConsoleApp1;

public class Program
{
    public static void Main(string[] args)
    {
        int c = 0, n = 1;
        List<int> list = new List<int>();
        int[] temp;

        int[] inputs = (
            from i 
            in Console.ReadLine().Split() 
            select Convert.ToInt32(i)
            ).ToArray<int>();
        int from = inputs[0];
        int to = inputs[1];

        while (c <= 1000)
        {
            temp = new int[n];
            Array.Fill(temp, n);
            list.AddRange(temp);
            c = c + n;
            n = n + 1;
        }

        Console.WriteLine(list.GetRange(from - 1, to - from + 1).Sum());
    }
}