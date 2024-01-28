// 11586 지영 공주님의 마법 거울

public class Program
{
    public static void Main(string[] args)
    {
        int n, l;
        n = Convert.ToInt32(Console.ReadLine());
        List<string> list = new List<string>();
        int length;

        for (int i = 0; i < n; i++)
        {
            list.Add(Console.ReadLine());
        }
        l = Convert.ToInt32(Console.ReadLine());

        switch (l)
        {
            case 1:
                list.ForEach(item => Console.WriteLine(item));
                break;
            case 2:
                length = list[0].Length;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < length; j++) 
                    {
                        Console.Write(list[i][length - 1 - j]);
                    }
                    Console.WriteLine();
                }
                break;
            case 3:
                for (int i = 0; i < n; i++) 
                {
                    Console.WriteLine(list[n - 1 - i]);
                }
                break;
        }
    }
}
