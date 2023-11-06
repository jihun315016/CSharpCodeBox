// 연습문제 > 대충 만든 자판

using System.Collections.Generic;

namespace ConsoleApp1;

public class Solution
{
    public int[] solution(string[] keymap, string[] targets)
    {
        int[] answer = new int[targets.Length];
        Dictionary<char, int> map = new Dictionary<char, int>();
        char chr;

        // 각 자판마다 입력에 필요한 최소의 수를 구해 딕셔너리에 저장
        for (int i = 0; i < keymap.Length; i++)
        {
            for (int j = 0; j < keymap[i].Length; j++)
            {
                chr = keymap[i][j];
                if (map.ContainsKey(chr) && map[chr] > j + 1)
                {
                    map[chr] = j + 1;
                }
                else if (!map.ContainsKey(chr)) 
                {
                    map.Add(chr, j + 1);
                }
            }
        }

        Array.Fill(answer, 0);
        for (int i = 0; i < targets.Length; i++)
        {
            for (int j = 0; j < targets[i].Length; j++)
            {
                chr = targets[i][j];
                if (map.ContainsKey(chr))
                {
                    answer[i] = answer[i] + map[chr];
                }
                else
                {
                    answer[i] = -1;
                    break;
                }
            }
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

        answer = solution.solution(new string[] { "ABACD", "BCEFD" }, new string[] { "ABCD", "AABB" });
        foreach(var a in answer) Console.Write($"{a} ");
        Console.WriteLine();

        answer = solution.solution(new string[] { "AA" }, new string[] { "B" });
        foreach (var a in answer) Console.Write($"{a} ");
        Console.WriteLine();

        answer = solution.solution(new string[] { "AGZ", "BSSS" }, new string[] { "ASA", "BGZ" });    
        foreach (var a in answer) Console.Write($"{a} ");
    }
}
