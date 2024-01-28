// 13717 포켓몬 GO 

class Program
{
    public static void Main(string[] args)
    {        
        int n = Convert.ToInt32(Console.ReadLine());
        string name;
        int[] k;
        int curCount;                       // 현재 검사하는 포켓몬이 진화할 수 있는 수
        int remainCandy;                    // 포켓몬을 진화시키고 남은 사탕 수
        int totalCount = 0;                 // 총 진화가능한 포켓몬 수
        int maxCount = 0;                   // 진화를 가장 많이 할 수 있는 포켓몬의 진화 수
        string maxCountName = string.Empty; // 가장 많은 진화를 할 수 있는 포켓몬 이름

        for (int i = 0; i < n; i++)
        {
            name = Console.ReadLine();
            k = (from item in Console.ReadLine().Split() select Convert.ToInt32(item)).ToArray();
            curCount = 0;

            // 진화 중 추가로 받은 사탕으로 인해 또 진화할 수 있는 경우때문에
            // 한 번에 계산하지 않고 while 루프를 돌 것
            while (k[1] >= k[0])
            {
                k[1] = k[1] - k[0] + 2;
                curCount = curCount + 1;
            }
            
            totalCount = totalCount + curCount;

            if (curCount > maxCount)
            {
                maxCount = curCount;
                maxCountName = name;
            }
        }

        Console.WriteLine(totalCount);
        Console.WriteLine(maxCountName);
    }
}