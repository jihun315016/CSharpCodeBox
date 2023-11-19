// 백준 1439 뒤집기

class Program
{
    static void Main(string[] args)
    {
        string s = Console.ReadLine();
        char curChar = default(char);
        Dictionary<char, int> map = new Dictionary<char, int>(); // 각 숫자마다 연결되어 있는 수
        map.Add('0', 0);
        map.Add('1', 0);

        foreach (char c in s)
        {
            if (!curChar.Equals(c))
            {
                curChar = c;
                map[c] = map[c] + 1;
            }
        }

        // 0이 연결된 수와 1이 연결된 수 중 더 적은만큼 뒤집으면 정답
        Console.WriteLine(Math.Min(map['0'], map['1']));
    }
}
