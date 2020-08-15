using System;

namespace AlgorithmsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Reverse an array
            //int[] sourceArray = new int[5] { 9, 8, 7, 6, 5 }; // expected 5, 6, 7, 8, 9
            //ArrayExercises.ReverseArray(sourceArray);

            // Find the 3rd maximum number
            int[] sourceArray = new int[6] { 1, 2, 3, 4, 5, 6 }; // expected 4
            ArrayExercises.ThirdMaximumNumber(sourceArray);


        }
    }
}
