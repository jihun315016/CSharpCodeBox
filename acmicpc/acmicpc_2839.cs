// 백준 2839 설탕 배달

class Program
{
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(GetCount(n));
    }

    static int GetCount(int n)
    {
        // 3kg 개수 확인
        for (int i = 0; i < n / 3 + 1; i++)
        {
            // 5kg 개수 확인
            for (int j = 0; j < n / 5 + 1; j++)
            {
                if (i * 3 + j * 5 == n)
                {
                    return i + j;
                }
            }
        }

        return -1;
    }
}
