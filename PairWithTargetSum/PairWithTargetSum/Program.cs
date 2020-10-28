using System;
using System.Collections.Generic;

namespace PairWithTargetSum
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        
        /// <summary>
        /// Standard two pointer approach
        /// </summary>
        /// <param name="arr">input array</param>
        /// <param name="targetSum">target sum</param>
        /// <returns>array of indices</returns>
        public int[] search(int[] arr, int targetSum)
        {
            int leftPointer = 0;
            int rightPointer = arr.Length -1;

                while(leftPointer < rightPointer) 
                {
                int currentSum = arr[leftPointer] + arr[rightPointer];

                    if(currentSum == targetSum)
                    {
                        return new int[] { leftPointer, rightPointer }; //search no further, we found our pair!
                    }

                if (targetSum > currentSum)
                {
                    leftPointer++;  //sum is too small, we need to increment the left pointer 
                }
                else
                    rightPointer--;  //sum is too big, we need to decrement the right pointer
                }
            return new int[] { -1, -1 };
        }

        /// <summary>
        /// This approach uses a Hashtable (or Dictionary): 
        /// Algorithm:
        /// 1. iterate through the array one number at a time. Lets say each number is X.
        /// 2. Mathematically, X + Y = Target, so we need to find Y. Mathematically, Y = Target - X. So, we search the hashtable for Target - X.
        /// 3. If Target - X exists in the hashtable, then we have found our pair. Otherwise, put X into the hashtable and move to the next value X in the array. 
        /// </summary>
        /// <param name="arr">input array</param>
        /// <param name="targetSum">target sum</param>
        /// <returns>array of indices</returns>
        public int[] useHashtableToSearch(int[] arr, int targetSum)
        {
            Dictionary<int, int> table = new Dictionary<int, int>();  //make a table to store numbers in the array and their respective indices

            for(int i=0; i < arr.Length; i++)
            {
                if (table.ContainsKey(targetSum - arr[i]))  
                {
                    return new int[] { table[targetSum - arr[i]], i }; //Bingo! We found Y = Target - X!
                }
                else
                    table.Add(arr[i], i);  //put number and its index in the array
            }

            return new int[] { -1, -1 }; //pair not found
        }
    }
}

