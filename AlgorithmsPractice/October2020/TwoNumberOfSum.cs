using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace AlgorithmsPractice.October2020
{
    public class TwoNumberOfSum
    {
        // Nested For loops
        // Time Complexity = O(N^2)
        // Space Complexity = O(1)
        public static int[] TwoNumSumNN(int[] arr, int sum)
        {
            int[] result = new int[2];
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == sum)
                    {
                        result[0] = arr[j];
                        result[1] = arr[i];
                    }
                }
            }
            return result;
        }

        // 1 For loop and 1 Dictionary
        // Time Complexity = O(N)
        // Space Complexity = O(N)
        public static int[] TwoNumSumON(int[] arr, int sum)
        {
            int[] result = new int[2];
            var checkedNumbers = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (checkedNumbers.ContainsKey(sum - arr[i]))
                {
                    result[0] = arr[i];
                    result[1] = sum - arr[i];
                }
                else
                {
                    checkedNumbers.Add(arr[i], 1);
                }
            }
            return result;
        }

        // 1 For loop on sorted array (quick sort or merge sort because they are log(N))
        // Time Complexity = O(N*log(N))
        // Space Complexity = O(1)
        public static int[] TwoNumSumSorted(int[] arr, int sum)
        {
            int[] result = new int[2];
            Array.Sort(arr);
            int left = 0;
            int right = arr.Length - 1;
            int currentSum = 0;
            while (left < right)
            {
                currentSum = arr[left] + arr[right];
                if (currentSum == sum)
                {
                    result[0] = arr[left];
                    result[1] = arr[right];
                    return result;
                }
                else if (currentSum < sum)
                {
                    left++;
                }
                else if (currentSum > sum)
                {
                    right++;
                }
            }
            return result;
        }
    }
}
