// 백준 1408 24

class Program
{
    static void Main(string[] args)
    {
        int[] curTime = (from item in Console.ReadLine().Split(':') select Convert.ToInt32(item)).ToArray<int>();
        int[] startTime = (from item in Console.ReadLine().Split(':') select Convert.ToInt32(item)).ToArray<int>();

        int curSecond = ConvertToSecond(curTime);
        int startSecond = ConvertToSecond(startTime);
        
        if (curSecond > startSecond)  
        {
            // 현재 시간이 시작 시간보다 크면 시작 시간에 하루를 더 해서 계산
            startSecond = startSecond + 24 * 3600;
        }

        Console.WriteLine(ConvertToTime(startSecond - curSecond));
    }

    static int ConvertToSecond(int[] time)
    {
        return time[0] * 3600 + time[1] * 60 + time[2];
    }

    static string ConvertToTime(int second)
    {
        string year, minute;

        year = (second / 3600).ToString("00");
        second = second % 3600;

        minute = (second / 60).ToString("00");
        second = second % 60;

        return $"{year}:{minute}:{second.ToString("00")}";
    }
}
