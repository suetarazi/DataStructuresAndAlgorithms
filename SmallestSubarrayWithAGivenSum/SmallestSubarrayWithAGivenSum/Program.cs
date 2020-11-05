using System;

namespace SmallestSubarrayWithAGivenSum
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public int findMinSubArray(int S, int[] arr)
        {
            
            int windowSum = 0;
            int windowStart = 0;
            int minLength = Int32.MaxValue;

            for (int windowEnd = 0; windowEnd < arr.Length; windowEnd++)
            {
                //cue up the window
                windowSum += arr[windowEnd];

                //keep cueing up the window until windowSum >= S
                while (windowSum >= S)
                {
                    //remember this length and set it to minLength
                    minLength = Math.Min(minLength, windowEnd - windowStart + 1);
                    //substract out the element at the start of the window
                    windowSum -= arr[windowStart];
                    //slide the window ahead
                    windowStart++;
                }

            }

            if (minLength == Int32.MaxValue)
            {
                return 0;
            }

            return minLength;

            //can also write a Ternary like this:
            //return minLength == Int32.MaxValue ? 0 : minLength;
        }
    }
}
