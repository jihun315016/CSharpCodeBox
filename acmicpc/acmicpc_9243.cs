// 9243 파일 완전 삭제

using System.Diagnostics.Metrics;

namespace ConsoleApp1;

public class Program
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string before = Console.ReadLine();
        string after = Console.ReadLine();

        if (isSucess(n, before, after))
        {
            Console.WriteLine("Deletion succeeded");
        }
        else
        {
            Console.WriteLine("Deletion failed");
        }
    }

    private static bool isSucess(int n, string before, string after)
    {
        // 짝수만큼 뒤집으면 결과는 똑같음
        if (n % 2 == 0)
        {
            if (before == after)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // 홀수만큼 뒤집으면 모든 값들이 반대
        else
        {
            for (int i = 0; i < before.Length; i++)
            {
                if (before[i] == after[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}