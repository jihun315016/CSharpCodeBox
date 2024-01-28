// 1817 짐 챙기는 숌

public class Program
{
    public static void Main(string[] args)
    {
        int[] input = (from item in Console.ReadLine().Split() select Convert.ToInt32(item)).ToArray();

        if (input[0] > 0)
        {
            int[] weights = (from item in Console.ReadLine().Split() select Convert.ToInt32(item)).ToArray();
            int curWeight = 0;
            int cnt = 1;

            for (int i = 0; i < weights.Length; i++)
            {
                if (curWeight + weights[i] > input[1])
                {
                    cnt = cnt + 1;
                    curWeight = weights[i];
                }
                else
                {
                    curWeight = curWeight + weights[i];
                }
            }

            Console.WriteLine(cnt);
        }
        else
        {
            Console.WriteLine(0);
        }
    }
}
