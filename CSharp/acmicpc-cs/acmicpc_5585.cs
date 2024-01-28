// 5585 거스름돈

class Program
{
    public static void Main(string[] args)
    {
        int n = 1000 - Convert.ToInt32(Console.ReadLine());
        List<int> list = new List<int>() { 500, 100, 50, 10, 5, 1 };
        int cnt;
        int answer = 0;

        foreach (int l in list) 
        {
            cnt = n / l;
            answer = answer + cnt;
            n = n - (l * cnt);
        }

        Console.WriteLine(answer);
    }
}