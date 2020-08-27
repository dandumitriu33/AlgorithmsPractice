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

        public static void FindPairsThatSum(int[] arr, int sum)
        {
            Dictionary<int, int> allNumbers = new Dictionary<int, int>();
            foreach (int number in arr)
            {
                allNumbers.Add(number, 1);
            }
            foreach (int value in arr)
            {
                int target = sum - value;
                if (allNumbers.ContainsKey(target))
                {
                    Console.WriteLine($"Paird found: {value}, {target}");
                }
            }
        }

        public static void FindPairsThatSumSortFirst(int[] arr, int sum)
        {
            Array.Sort(arr);
            int left = 0;
            int right = arr.Length - 1;
            while(left < right)
            {
                int pointersSum = arr[left] + arr[right];
                if (pointersSum == sum)
                {
                    Console.WriteLine($"Pair found: {arr[left]} and {arr[right]}");
                    left++;
                    right--;
                }
                else if (pointersSum < sum)
                {
                    left++;
                }
                else if (pointersSum > sum)
                {
                    right--;
                }
            }


        }

    }
}
