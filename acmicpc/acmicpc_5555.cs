// 5555 반지

class Program
{
    public static void Main(string[] args)
    {
        string str = Console.ReadLine();
        int n = Convert.ToInt32(Console.ReadLine());
        string k;
        int answer = 0;

        for(int i = 0; i < n; i++)
        {
            k = Console.ReadLine();
            k = k + k;
            if (k.Contains(str))
            {
                answer = answer + 1;
            }
        }

        Console.WriteLine(answer);
    }
}