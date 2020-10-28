using System;
using System.Collections.Generic;

namespace LongestSubstringWithKDistinctCharacters
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public int findLength(String str, int k)
        {
            //deal with your edge cases:
            if (str == null || str.Length == 0 || str.Length < k)
            {
                throw new ArgumentException();
            }

            int windowStart = 0;
            int maxSubstring = 0;
            Dictionary<char, int> charFrequency = new Dictionary<char, int>();

            //in this loop, we try and extend the width of the window [windowStart, windowEnd]            
            for (int windowEnd = 0; windowEnd < str.Length; windowEnd++)
            {

                char rightChar = str[windowEnd];


                //charFrequency[rightChar] += 1;

                if (!(charFrequency.ContainsKey(rightChar)))
                {
                    charFrequency[rightChar] = 0;

                }
                charFrequency[rightChar] += 1;

                //Now try and shrink the sliding window until we have k distinct characters in the character frequency

                while (charFrequency.Count > k)
                {
                    char leftChar = str[windowStart];

                    charFrequency[leftChar] -= 1;

                    if (charFrequency[leftChar] == 0)
                    {
                        charFrequency.Remove(leftChar);
                    }
                    windowStart++;
                }

                //window size is windowEnd - windowStart +1
                maxSubstring = Math.Max(maxSubstring, windowEnd - windowStart + 1);

            }

            return maxSubstring;
        }


    }
}

