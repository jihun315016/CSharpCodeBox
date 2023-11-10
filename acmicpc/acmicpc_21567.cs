// 21567 숫자의 개수 2 

namespace ConsoleApp1;

public class Program
{
    public static void Main(string[] args)
    {
        decimal num = 1;
        for (int i = 0; i < 3; i++) 
        {
            num = num * Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(num.ToString().Count(n => n == i.ToString()[0]));
        }
    }
}
