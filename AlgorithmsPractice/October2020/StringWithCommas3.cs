using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsPractice.October2020
{
    public class StringWithCommas3
    {
        public static string CommaAt3(int number)
        {
            // input number must be transformed in comma separated number as string 
            // at 3 units - like US representation of large numbers
            // Time Complexity O(N)
            // Space Complexity O(N) + N/3?

            string numberAsString = number.ToString();
            int stringLength = numberAsString.Length;
            int commaCounter = 0;
            StringBuilder result = new StringBuilder();
            for (int i = stringLength - 1; i >= 0; i--)
            {
                commaCounter++;
                result.Insert(0, numberAsString[i]);
                if (commaCounter%3 == 0 && commaCounter < stringLength)
                {
                    result.Insert(0, ",");
                }
            }
            return result.ToString();
        }
    }
}
