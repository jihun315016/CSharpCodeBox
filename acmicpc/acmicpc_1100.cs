// 백준 1100 하얀 칸

class Program
{
    static void Main(string[] args)
    {
        string line;
        int cnt = 0;

        for (int i = 0; i < 8; i++)
        {
            line = Console.ReadLine();
            cnt = cnt + GetCount(line, i % 2);
        }

        Console.WriteLine(cnt);
    }

    /// <summary>
    /// 하얀 칸 위에 말의 개수 출력
    /// </summary>
    /// <param name="line"></param>
    /// <param name="start">하얀 칸이 있는 시작 지점</param>
    /// <returns></returns>
    static int GetCount(string line, int start)
    {
        int cnt = 0;
        // i는 하얀칸
        for (int i = start; i < 8; i = i + 2)
        {
            if (line[i].Equals('F'))
            {
                cnt++;
            }
        }
        return cnt;
    }
}
