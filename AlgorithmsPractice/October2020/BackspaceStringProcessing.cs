using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsPractice.October2020
{
    public class BackspaceStringProcessing
    {
        public static string ProcessString(string input)
        {
            // each # is considered a Backspace and when it is met, it removes a letter from the string
            // indexing is the fastest way apparently to iterate through a string
            // https://stackoverflow.com/questions/8793762/what-is-the-fastest-way-to-iterate-through-individual-characters-in-a-string-in

            // Time Complexity O(N)
            // Space Complexity O(N) - the stringbuilder if no #

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Equals('#') == true)
                {
                    if (result.Length > 0)
                    {
                        result.Remove(result.Length - 1, 1);
                    } 
                }
                else
                {
                    result.Append(input[i]);
                }
            }
            return result.ToString();
        }
    }
}
