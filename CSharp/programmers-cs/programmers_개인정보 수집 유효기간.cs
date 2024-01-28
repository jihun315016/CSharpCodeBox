// 2023 KAKAO BLIND RECRUITMENT > 개인정보 수집 유효기간

using System;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();

        // [1, 3]
        Console.WriteLine
        (
            solution.solution
            (
                "2022.05.19"
                , new string[] { "A 6", "B 12", "C 3" }
                , new string[] { "2021.05.02 A", "2021.07.01 B", "2022.02.19 C", "2022.02.20 C" }
            )
        );

        // [1, 4, 5]
        Console.WriteLine
        (
            solution.solution
            (
                "2020.01.01"
                , new string[] { "Z 3", "D 5" }
                , new string[] { "2019.01.01 D", "2019.11.15 Z", "2019.08.02 D", "2019.07.01 D", "2018.12.28 Z" }
            )
        );
    }
}



class Solution
{
    public int[] solution(string today, string[] terms, string[] privacies)
    {
        List<int> answer = new List<int>();
        Dictionary<string, int> termsMap = new Dictionary<string, int>();
        string[] termsArr;
        string[] privaciesArr;
        DateTime dt;
        string strDT;

        foreach (string t in terms) 
        {
            termsArr = t.Split();
            termsMap.Add(termsArr[0], Convert.ToInt32(termsArr[1]));
        }

        for (int i = 0; i < privacies.Length; i++) 
        {
            // { "A", "2021.05.02" }
            privaciesArr = privacies[i].Split();

            // termsMap[privaciesArr[1]] 개월 - 하루 뒤 날짜 계산
            // 문제에서 각 월은 28일까지만 있다고 가정
            dt = Convert.ToDateTime(privaciesArr[0]).AddMonths(termsMap[privaciesArr[1]]).AddDays(-1);
            if (dt.Day > 28)
            {
                dt = new DateTime(dt.Year, dt.Month, 28);
            }

            strDT = dt.ToString("yyyy.MM.dd");
            if (string.Compare(today, strDT) > 0)
            {
                answer.Add(i + 1);
            }
        }
        
        return answer.ToArray();
    }
}
