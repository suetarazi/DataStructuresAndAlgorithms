using System;
using System.Collections.Generic;

namespace FruitsIntoBaskets
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public int findLength(char[] arr)
        {

            int windowStart = 0;
            int maxSubstring = 1;

            Dictionary<char, int> fruitMap = new Dictionary<char, int>();

            //grow the window
            for (int windowEnd = 0; windowEnd < arr.Length; windowEnd++)
            {
                char rightChar = arr[windowEnd];

                if (!fruitMap.ContainsKey(rightChar))
                {
                    //add rightChar to dictionary as the key, assigns 0 as its value
                    fruitMap[rightChar] = 0;
                }
                //update dictionary for key rightChar and update its value +1
                fruitMap[rightChar] += 1;

                //now we try and shrink the window, keeping two distinct characters in the fruitMap
                while (fruitMap.Count > 2)
                {
                    char leftChar = arr[windowStart];

                    //update dictionary for key leftChar and update its value by -1
                    fruitMap[leftChar] -= 1;

                    //if the value of leftChar reaches 0, remove it from the dictionary
                    if (fruitMap[leftChar] == 0)
                    {
                        fruitMap.Remove(leftChar);

                    }

                    windowStart++;
                }
                maxSubstring = Math.Max(maxSubstring, windowEnd - windowStart + 1);
            }


            return maxSubstring;
        }
    }
}
