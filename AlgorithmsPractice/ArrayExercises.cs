﻿using System;
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

        public static int MaxHourglass(int[,] sourceArray)
        {
            int axisLength = 6; // 6x6 matrix
            int result = -63;
            // boundaries
            for (int i = 0; i <= (axisLength - 1) - 2; i++)
            {
                for (int j = 0; j <= (axisLength - 1) - 2; j++)
                {
                    // hourglass structure
                    int sum = sourceArray[i, j] + sourceArray[i, j + 1] + sourceArray[i, j + 2] + 
                                                  sourceArray[i + 1, j + 1] + 
                          sourceArray[i + 2, j] + sourceArray[i + 2, j + 1] + sourceArray[i + 2, j + 2];
                    Console.WriteLine($"This sum is: {sum}");
                    if (sum > result)
                    {
                        result = sum;
                    }
                }
            }
            // printing
            Console.WriteLine(result);

            return result;
        }

        public static int[] SortArrayParityTONSON(int[] input)
        {
            int[] output = new int[input.Length];
            int j = 0;
            foreach (int number in input)
            {
                if (number % 2 == 0)
                {
                    output[j] = number;
                    j++;
                }
            }
            foreach (int number in input)
            {
                if (number % 2 != 0)
                {
                    output[j] = number;
                    j++;
                }
            }
            // printing
            foreach (int number in output)
            {
                Console.Write($"{number} ");
            }
            return output;
        }
        public static int[] SortArrayParityTONSO1(int[] input)
        {
            int i = 0;
            for (int j = 0; j < input.Length; j++)
            {
                if (input[j] % 2 == 0)
                {
                    int temp = input[i];
                    input[i] = input[j];
                    input[j] = temp;
                    i++;
                }
            }
            // printing
            foreach (int number in input)
            {
                Console.Write($"{number} ");
            }
            return input;
        }
    }
}
