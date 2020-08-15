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
            //int[] sourceArray = new int[6] { 1, 2, 3, 4, 5, 6 }; // expected 4
            //ArrayExercises.ThirdMaximumNumber(sourceArray);

            // Max Hourglass sum in matrix (6x6 array) -9 is the lowest number
            //int[,] sourceArray = new int[,]
            //{
            //    { -9, -9, -9, 1, 1, 1 },
            //    { 0, -9, 0, 4, 3, 2},
            //    { -9, -9, -9, 1, 2, 3},
            //    { 0, 0, 8, 6, 6, 0},
            //    { 0, 0, 0, -2, 0, 0},
            //    { 0, 0, 1, 2, 4, 0}
            //};
            //ArrayExercises.MaxHourglass(sourceArray);

            // Sort array by parity - even numbers first, then odd numbers
            // Time complexity O(N), Space complexity O(N)
            int[] sourceArray = new[] { 3, 4, 2, 1 }; // expected 4 2 3 1
            ArrayExercises.SortArrayParityTONSON(sourceArray);
            // Time complxity O(N), Space complexity O(1)
            Console.WriteLine();
            ArrayExercises.SortArrayParityTONSO1(sourceArray);







        }
    }
}
