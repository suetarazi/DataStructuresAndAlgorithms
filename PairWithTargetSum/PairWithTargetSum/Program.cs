using System;

namespace PairWithTargetSum
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

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
    }
}

