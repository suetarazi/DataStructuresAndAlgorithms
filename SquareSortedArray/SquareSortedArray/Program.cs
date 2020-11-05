using System;
using System.Collections.Immutable;

namespace SquareSortedArray
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// Brute force solution
        /// </summary>
        /// <param name="arr">input array</param>
        /// <returns>new array of squared values</returns>
        public int[] BruteForceMakeSquares(int[] arr)
        {
            int[] squares = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                squares[i] = arr[i] * arr[i];
            }

            Array.Sort(squares);


            return squares;
        }

        /// <summary>
        /// Two pointer solution: find index of the first non-negative number. Then use two pointers from that index, moving in opposite directions. At each step, whichever number squared is larger is added to the array first
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public int[] makeSquaresTwoPointer(int[] arr)
        {
            int[] squares = new int[arr.Length];

            int highestSquareIdx = arr.Length - 1;
            int left = 0;
            int right = arr.Length - 1; 

            while(left <= right)
            {
                int leftSquare = arr[left] * arr[left];
                int rightSquare = arr[right] * arr[right];

                if(leftSquare > rightSquare)
                {
                    squares[highestSquareIdx--] = rightSquare;
                    right--;
                }
            }

            return squares;
        }
    }
}