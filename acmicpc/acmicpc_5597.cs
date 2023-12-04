// 5597 과제 안 내신 분..?

class Program
{
    public static void Main(string[] args)
    {
        int[] arr = new int[30];
        Array.Fill(arr, 0);

        for(int i = 0; i < 28; i++) 
        {
            arr[Convert.ToInt32(Console.ReadLine()) - 1] = 1;
        }

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == 0) 
            {
                Console.WriteLine(i + 1);
            }
        }
    }
}