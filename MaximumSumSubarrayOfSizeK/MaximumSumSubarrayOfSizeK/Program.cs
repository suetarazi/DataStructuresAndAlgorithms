using System;

namespace MaximumSumSubarrayOfSizeK
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// Brute force method
        /// </summary>
        /// <param name="k">width of window</param>
        /// <param name="arr">input array</param>
        /// <returns></returns>
        public int findMaxSumSubArray(int k, int[] arr)
        {

            int maxSum = 0;
            int currentSum;

            for (int i = 0; i <= (arr.Length - k); i++)
            {
                currentSum = 0;
                for (int j = i; j < (i + k); j++)
                {
                    currentSum += arr[j];
                }
                maxSum = Math.Max(maxSum, currentSum);
            }
            return maxSum;
        }

        /// <summary>
        /// Optimized solution using sliding windows
        /// </summary>
        /// <param name="k">window width</param>
        /// <param name="arr">input array</param>
        /// <returns></returns>
        public int findMaxSumSubArrayOptimized(int k, int[] arr)
        {
            int maxSum = 0;
            int windowSum = 0;
            int windowStart = 0;

            for (int windowEnd = 0; windowEnd < arr.Length; windowEnd++)
            {
                //add elements into the window
                windowSum += arr[windowEnd];

                //wait until you have k elements in the window
                if (windowEnd >= k - 1)
                {
                    //assess for maxSum
                    maxSum = Math.Max(maxSum, windowSum);

                    //subtract the outgoing element
                    windowSum -= arr[windowStart];
                    //slide the start of the window over one
                    windowStart++;
                }

            }

            return maxSum;
        }

    }
}
