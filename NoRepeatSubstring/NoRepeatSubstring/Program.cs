using System;
using System.Collections.Generic;

namespace NoRepeatSubstring
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        //find the length of the longest substring which has no repeating characters
        public int findLength(string str)
        {
            int windowStart = 0;
            int maxSubstring = 1;

            Dictionary<char, int> charList = new Dictionary<char, int>();

            //grow the window
            for (int windowEnd = 0; windowEnd < str.Length; windowEnd++)
            {
                char rightChar = str[windowEnd];

                //if the dictionary already contains rightChar, shrink the window from windowStart so we only have ONE occurance of rightChar
                if (charList.ContainsKey(rightChar))
                {
                    windowStart = Math.Max(windowStart, charList[rightChar] + 1);
                }

                //insert rightChar into the dictionary
                charList[rightChar] = windowEnd;

                //remember the max substring length so far
                maxSubstring = Math.Max(maxSubstring, windowEnd - windowStart + 1);
            }


            return maxSubstring;
        }
    }
}
