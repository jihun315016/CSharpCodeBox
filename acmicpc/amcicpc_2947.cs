// 백준 2947 나무 조각

namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = (
                from n 
                in Console.ReadLine().Split() 
                select Convert.ToInt32(n)
                ).ToArray<int>();

            int temp;

            for(int i = 0; i < arr.Length - 1; i++)
            {
                for(int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        Console.WriteLine(string.Join(' ', arr));
                    }
                }
            }
        }
    }
}