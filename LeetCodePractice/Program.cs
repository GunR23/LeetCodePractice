using System;

namespace LeetCodePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 0, 2, 3, 0, 4, 5, 0 };
            int[] arr2 = { 1, 2, 3 };
            DuplicateZeros(arr1);
            DuplicateZeros(arr2);
            Console.WriteLine("[{0}]", string.Join(", ", arr1));
            Console.WriteLine("[{0}]", string.Join(", ", arr2));
        }

        public static void DuplicateZeros(int[] arr)
        {
            if (Array.Exists(arr, e => e.Equals(0)))
            {
                // The loop is length - 1 times because the last one mustn't be 0.
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] == 0)
                    {
                        for (int j = arr.Length - 2; j > i; j--)
                        {
                            arr[j + 1] = arr[j];
                        }
                        arr[i + 1] = 0;
                        i++;
                    }
                }
            }
        }
    }
}
