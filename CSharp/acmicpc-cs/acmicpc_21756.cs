// 21756 지우개

public class Program
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        List<int> list = new List<int>();

        for (int i = 1; i <= n; i++)
        {
            list.Add(i);
        }

        while (list.Count > 1)
        {
            list = list.Where((value, index) => index % 2 == 1).ToList();
        }

        Console.WriteLine(list[0]);
    }
}