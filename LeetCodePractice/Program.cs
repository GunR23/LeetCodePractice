using System;
using System.Linq;
using System.Collections.Generic;
namespace LeetCodePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 0, 1, 1, 1, 1, 2, 2, 3, 3, 4 };
            var length = RemoveDuplicates(arr);
            Console.WriteLine(length);
            for (int i = 0; i < length; i++)
            {
                System.Console.WriteLine($"item number {i} is: {arr[i]}");
            }
        }

        /// <summary>
        /// https://leetcode.com/explore/learn/card/fun-with-arrays/527/searching-for-items-in-an-array/3250/
        /// </summary>
        /// <param name="arr">Array of ints</param>
        /// <returns>Whether there is an element that is a double of another</returns>
        public bool CheckIfExist(int[] arr)
        {
            int length = arr.Length;
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (i != j && arr[i] == 2 * arr[j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// https://leetcode.com/explore/learn/card/fun-with-arrays/526/deleting-items-from-an-array/3248/
        /// </summary>
        /// <param name="nums">Array of ints</param>
        /// <returns>Amount of distinct ints</returns>
        public static int RemoveDuplicates(int[] nums)
        {
            int i = 0;
            foreach(int n in nums) 
            {
                if (i == 0 || n > nums[i-1]) 
                {
                    nums[i++] = n;
                }
            }
            return i;
        }

        /// <summary>
        /// https://leetcode.com/explore/learn/card/fun-with-arrays/526/deleting-items-from-an-array/3247/
        /// </summary>
        /// <param name="nums">Array of ints.</param>
        /// <param name="val">Values to remove from nums.</param>
        /// <returns>Amount of remaining elements in nums.</returns>
        public static int RemoveElement(int[] nums, int val)
        {
            int count = 0;
            int length = nums.Length - 1;
            for (int i = length; i >= 0; i--)
            {
                if (nums[i] == val)
                {
                    int lastVal = nums[length];
                    length--;
                    nums[i] = lastVal;
                    count++;
                }
            }
            return nums.Length - count;
        }

        /// <summary>
        /// https://leetcode.com/explore/learn/card/fun-with-arrays/525/inserting-items-into-an-array/3253/
        /// </summary>
        /// <param name="nums1">Array to merge elements to.</param>
        /// <param name="m">Length of nums1</param>
        /// <param name="nums2">Array to merge into nums1</param>
        /// <param name="n">Length of nums2</param>
        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            if (n == 0) return;
            if (m == 0)
            {
                Array.Copy(nums2, nums1, nums1.Length);
                return;
            }

            int usedNumbersFrom2 = 0;
            for (int indexNums1 = 0; indexNums1 < m + n; indexNums1++)
            {
                int index2 = usedNumbersFrom2;
                while (index2 < n)
                {
                    if (indexNums1 >= m + usedNumbersFrom2)
                    {
                        nums1[indexNums1] = nums2[usedNumbersFrom2];
                        usedNumbersFrom2++;
                        break;
                    }

                    if (nums1[indexNums1] > nums2[index2])
                    {
                        for (int j = m + n - 2; j >= indexNums1; j--)
                        {
                            nums1[j + 1] = nums1[j];
                        }

                        nums1[indexNums1] = nums2[index2];
                        usedNumbersFrom2++;
                    }

                    index2++;
                }
            }
        }

        /// <summary>
        /// https://leetcode.com/explore/learn/card/fun-with-arrays/525/inserting-items-into-an-array/3245/
        /// </summary>
        /// <param name="arr">Input array</param>
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