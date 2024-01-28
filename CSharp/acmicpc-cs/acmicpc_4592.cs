// 백준 4592 중복을 없애자

public class Program
{
    public static void Main(string[] args)
    {
        List<int> list = new List<int>();
        int n;
         
        while (true)
        {
            list = (
                from i
                in Console.ReadLine().Split()
                select Convert.ToInt32(i)
                ).ToList<int>();
            
            if (list[0] == 0) 
                break;

            n = -1;
            for (int i = 1; i < list.Count; i++) 
            {
                if (list[i] != n)
                {
                    n = list[i];
                    Console.Write($"{list[i]} ");
                }
            }

            Console.WriteLine("$");
        }
    }
}