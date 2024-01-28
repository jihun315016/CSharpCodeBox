// 1292 쉽게 푸는 문제

using System.Text;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {        
        int[] arr = (from item in Console.ReadLine().Split() select Convert.ToInt32(item)).ToArray<int>();
        int from = arr[0], to = arr[1];
        List<int> list = new List<int>();
        int n = 1;
        int[] temp;

        while (to > list.Count)
        {
            temp = new int[n];
            Array.Fill(temp, n);
            list.AddRange(temp);
            n = n + 1;
        }

        Console.WriteLine(list.GetRange(from - 1, to - from + 1).Sum());
    }
}