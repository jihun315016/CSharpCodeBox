// 21866 커피를 통해 추첨을 받자

public class Program
{
    public static void Main(string[] args)
    {
        List<int> list = (from item in Console.ReadLine().Split() select Convert.ToInt32(item)).ToList<int>();
        int[] scores = new int[] { 100, 100, 200, 200, 300, 300, 400, 400, 500 };


        for (int i = 0; i < list.Count; i++)
        {
            if (list[i] > scores[i])
            {
                Console.WriteLine("hacker"); 
                return;
            }
        }

        if (list.Sum() >= 100)
        {
            Console.WriteLine("draw");
        }
        else
        {
            Console.WriteLine("none");
        }
    }
}