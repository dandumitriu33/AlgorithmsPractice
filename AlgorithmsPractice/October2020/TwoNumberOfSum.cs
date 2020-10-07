using System;
using System.Collections.Generic;
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
                        result[0] = arr[i];
                        result[1] = arr[j];
                    }
                }
            }
            return result;
        }
    }
}
