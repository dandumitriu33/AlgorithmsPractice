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

        public static int FindDuplicateNumber(int[] arr)
        {
            Dictionary<int, int> numbers = new Dictionary<int, int>();
            foreach (int number in arr)
            {
                if (numbers.ContainsKey(number))
                {
                    return number;
                }
                else
                {
                    numbers.Add(number, 1);
                }
            }

            return 0;
        }

        public static void FindLargestAndSmallest(int[] arr)
        {
            int largest = arr[0];
            int smallest = arr[0];
            foreach (int number in arr)
            {
                if (number > largest)
                {
                    largest = number;
                }
                else if (number < smallest)
                {
                    smallest = number;
                }
            }
            Console.WriteLine($"The smallest number is {smallest} and the largest is {largest}");
        }

    }
}
