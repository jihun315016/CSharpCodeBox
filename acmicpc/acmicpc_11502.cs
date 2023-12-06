// 11502 세 개의 소수 문제

public class Program
{
    public static void Main(string[] args)
    {
        List<int> list = new List<int>() { 2 };

        for (int i = 2; i < 1001; i++) 
        {
            if (IsPrime(i)) 
            {
                list.Add(i);
            }            
        }

        int n = Convert.ToInt32(Console.ReadLine());
        int k;
        List<int> temp;
        for (int i = 0; i < n; i++)
        {
            k = Convert.ToInt32(Console.ReadLine());
            temp = MixedList(list, k);
            if (temp == null) 
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine($"{temp[0]} {temp[1]} {temp[2]}");
            }
        }
    }


    public static bool IsPrime(int num)
    {
        for (int i = 2; i < num + 1; i++)
        {
            if (i * i > num) 
            {
                return true;
            }

            if (num % i == 0) 
            {
                return false;
            }
        }

        return true;
    }
    

    public static List<int> MixedList(List<int> list, int num)
    {
        for (int i = 0; i < list.Count; i++) 
        {
            for (int j = i; j < list.Count; j++)
            {
                for (int k = i; k < list.Count; k++)
                {
                    if (list[i] + list[j] + list[k] == num) 
                    {
                        return new List<int>() { list[i], list[j], list[k] }; 
                    }
                }
            }
        }

        return null;
    }
}