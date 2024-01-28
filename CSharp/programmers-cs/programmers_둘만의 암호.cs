// 연습문제 > 둘만의 암호

using System.Text;

class Program
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();

        // happy
        Console.WriteLine(solution.solution("aukks", "wbqd", 5));
    }
}



class Solution
{
    public string solution(string s, string skip, int index)
    {
        StringBuilder answer = new StringBuilder();
        int key;

        List<char> list = new List<char>();

        for (char c = 'a'; c <= 'z'; c++)
        {
            if (!skip.Contains(c)) 
            {
                list.Add(c);
            }
        }

        foreach (char c in s)
        {
            key = (list.IndexOf(c) + index) % (26 - skip.Length);
            answer.Append(list[key]);
        }

        return answer.ToString();
    }
}
