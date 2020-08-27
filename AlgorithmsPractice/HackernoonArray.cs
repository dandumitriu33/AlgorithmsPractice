using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmsPractice
{
    public class HackernoonArray
    {
        public static int FindMissingNumber(int[] arr, int[] fullArr)
        {
            // numbers are from 1 to 100 and only one is missing
            int total = fullArr.Length*(fullArr.Length + 1) / 2;
            int arrSum = arr.Sum();
            return total - arrSum;
        }
    }
}
