using System;
using System.Collections.Generic;
using System.Linq;

namespace LongestSubstringWithSameLettersAfterReplacement
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public int findLength(String str, int k)
        {
            int windowStart = 0;
            int maxSubstring = 0;
            int maxRepeatLetterCount = 0;
            Dictionary<char, int> map = new Dictionary<char, int>();

            for (int windowEnd = 0; windowEnd < str.Length; windowEnd++)
            {
                char rightChar = str[windowEnd];
                //first, put all the characters in the map
                if (!map.ContainsKey(rightChar))
                {
                    map.Add(rightChar, 1);
                }
                else
                {
                    map[rightChar] += 1;
                }

                //get the character with the largest value from the map
                int maxRepeatLetterCount = Math.Max(maxRepeatLetterCount, map.TryGetValue(windowEnd));

                //current window size is from windowStart to windowEnd, so overall we have a letter that is repeating 'maxRepeatLetterCount' times. So, we therefore have a window with maxRepeatLetterCount times of one letter and the remaining letters we should try and replace. If the remaining letters are > k, then we need to shrink our window since we can only replace no more than k letters. 
                if (windowEnd - windowStart + 1 - maxRepeatLetterCount > k)
                {
                    char leftChar = str[windowStart];

                    map.Add[leftChar] - 1;

                    windowStart++;
                }

                maxSubstring = Math.Max(maxSubstring, windowStart - windowEnd + 1);

            }

            return maxSubstring;

        }
    }
}
