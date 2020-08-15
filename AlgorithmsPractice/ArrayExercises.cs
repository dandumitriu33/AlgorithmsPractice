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
    }
}