using System;

namespace SplashSort
{
    class Program
    {
        public static void sort(int[] arr)
        {
            for(int i = 0; i <= arr.Length-1; i++)
                for(int j = 0; j <= arr.Length-1; j++)
                    if(arr[i] < arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
        }

        public static void printArray(int[] arr)
        {
            foreach(int i in arr)
                Console.Write($"{i} ");
        }
        static void Main(string[] args)
        {
            Console.Clear();
            Random random = new Random();
            int[] unsorted_arr = new int[10];
            for(int i = 0; i <= 9; i++)
                unsorted_arr[i] = random.Next(1, 100);
            printArray(unsorted_arr);
            Console.WriteLine();
            sort(unsorted_arr);
            printArray(unsorted_arr);
            Console.ReadKey();
        }
    }
}
