using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmsPractice
{
    public class StringExercises
    {
        public static string FirstNonRepeatingTNSquared(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                bool seenDuplicate = false;
                for (int j = 0; j < input.Length; j++)
                {
                    if (input[i] == input[j] && i != j)
                    {
                        seenDuplicate = true;
                        break;
                    }
                }
                if (!seenDuplicate)
                {
                    return input[i].ToString();
                }
            }
            return "_";
        }

        public static string FirstNonRepeatingTN2Dictionary(string input)
        {
            Dictionary<string, int> charCounts = new Dictionary<string, int>();
            // populate a dictionary with the characters and frequency
            for (int i = 0; i < input.Length; i++)
            {
                string character = input[i].ToString();
                if (charCounts.ContainsKey(character))
                {
                    charCounts[character] = charCounts[character] + 1;
                }
                else
                {
                    charCounts[character] = 1;
                }
            }
            // as the dictionary is not ordered, but lookup is O(1) constant time we loop again 
            for (int i = 0; i < input.Length; i++)
            {
                string lookingAt = input[i].ToString();
                if (charCounts[lookingAt] == 1)
                {
                    return lookingAt;
                }
            }

            return "_";

        }

        public static string FirstNonRepeatingTN2Array(string input)
        {
            // instead of a dictionary we use a 26 slot (English alphabet no of letters) array of 0
            int[] charCounts = Enumerable.Repeat(0, 26).ToArray();

            foreach (var letter in input)
            {
                charCounts[letter - 'a']++;
            }

            foreach (var letter in input)
            {
                if (charCounts[letter - 'a'] == 1)
                {
                    return letter.ToString();
                }
            }

            return "_";
        }


    }
}
