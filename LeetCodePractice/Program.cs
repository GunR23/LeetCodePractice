using System;
using System.Linq;
using System.Security.Cryptography;

namespace LeetCodePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
        }

        /// <summary>
        /// https://leetcode.com/explore/learn/card/fun-with-arrays/526/deleting-items-from-an-array/3248/
        /// </summary>
        /// <param name="nums">Array of ints</param>
        /// <returns>Amount of distinct ints</returns>
        public int RemoveDuplicates(int[] nums)
        {
            int length = nums.Length;
            for (int i = 1; i < length; i++)
            {
                if (nums[i - 1] == nums[i])
                {

                }
            }

            return 0;
        }

        /// <summary>
        /// https://leetcode.com/explore/learn/card/fun-with-arrays/526/deleting-items-from-an-array/3247/
        /// </summary>
        /// <param name="nums">Array of ints.</param>
        /// <param name="val">Values to remove from nums.</param>
        /// <returns>Amount of remaining elements in nums.</returns>
        public int RemoveElement(int[] nums, int val)
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