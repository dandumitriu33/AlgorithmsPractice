using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AlgorithmsPractice
{
    public class ArrayExercises
    {
        public static int[] ReverseArray(int[] sourceArray)
        {
            int[] result = new int[sourceArray.Length];
            for (int i = sourceArray.Length-1; i >= 0; i--)
            {
                result[(sourceArray.Length-1) - i] = sourceArray[i];
            }
            // printing
            foreach (var number in result)
            {
                Console.Write($"{number} ");
            }
            return result;
        }

        public static int ThirdMaximumNumber(int[] sourceArray)
        {
            int result = 0;
            int firstMax = 0;
            int secondMax = 0;
            int thirdMax = 0;

            foreach (int number in sourceArray)
            {
                if (number > firstMax)
                {
                    thirdMax = secondMax;
                    secondMax = firstMax;
                    firstMax = number;
                }
                else if (number > secondMax)
                {
                    thirdMax = secondMax;
                    secondMax = number;
                }
                else if (number > thirdMax)
                {
                    thirdMax = number;
                }
            }
            result = thirdMax;
            // printing
            Console.WriteLine(result);
            return result;
        }
    }
}
