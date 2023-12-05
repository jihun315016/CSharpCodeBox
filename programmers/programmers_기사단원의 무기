// 연습문제 > 기사단원의 무기

public class Solution
{
    public int solution(int number, int limit, int power)
    {
        int answer = 0;
        int count;

        for(int i = 1; i < number + 1; i++)
        {
            count = 0;
            for (int j = 1; j < i + 1; j++) 
            {
                if (j * j > i)
                {
                    count = count * 2;
                    break;
                }
                else if (j * j == i) // 5 * 5 == 25
                {
                    count = count * 2 + 1;
                    break;
                }
                else if (i % j == 0)
                {
                    count = count + 1;
                }
            }

            if (count > limit)
            {
                count = power;
            }

            answer = answer + count;
        }

        return answer;
    }
}



public class Program
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        int[] answer;
       
        // 10
        Console.WriteLine(solution.solution(5, 3, 2));

        // 21
        Console.WriteLine(solution.solution(10, 3, 2));
    }
}
