using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsPractice.October2020
{
    public class RectangleIntoSquares
    {
        /*
         * You have the length and width of a rectangle. 
         * The rectangle can be divided in squares via width. The width of the rectangle becomes a square side.
         * Return a list of square side sizes after each square is processed and eliminated.
         * https://www.codewars.com/kata/55466989aeecab5aac00003e/csharp
         */
        public static List<int> FindSquareSizes(int length, int width)
        {
            if (length == width)
            {
                return null;
            }
            if (width > length)
            {
                int temp = width;
                width = length;
                length = temp;
            }
            List<int> result = new List<int>();
            while (width >= 1)
            {
                for (int i = 0; i < length/width; i++)
                {
                    result.Add(width);
                }
                int temp = length % width;
                length = width;
                width = temp;
            }
            return result;
        }
    }
}
