// 1453 피시방 알바

using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {        
        int n = Convert.ToInt32(Console.ReadLine());
        List<int> list = (from item in Console.ReadLine().Split() select Convert.ToInt32(item)).Distinct().ToList<int>();
        
        Console.WriteLine(n - list.Count);
    }
}