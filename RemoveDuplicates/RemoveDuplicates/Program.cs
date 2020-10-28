using System;
using System.Collections.Generic;

namespace RemoveDuplicates
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public int remove(int[] arr)
        {
            int nextNonduplicate = 1; //index of the next non-duplicate
            
            for(int i=1; i < arr.Length; i++)
            {
                if(arr[i] != arr[nextNonduplicate])
                {
                    arr[nextNonduplicate] = arr[i];
                    nextNonduplicate++;
                }
            }
            return nextNonduplicate;
        }

        /// <summary>
        ///  Given an unsorted array of numbers and a target ‘key’, remove all instances of ‘key’ in-place and return the new length of the array.
        /// </summary>
        /// <param name="arr">input array</param>
        /// <param name="key">key to be removed from the array</param>
        /// <returns>length of the new array (i.e. how many numbers did we count up that we want to keep)</returns>
        public int removeKey(int[] arr, int key)
        {
            int nextElement = 0; //index of next element that is not our key

            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] != key)
                {
                    arr[nextElement] = arr[i];  //next element gets to jump to that point in the array
                    nextElement++;    //increment the count of elements we want to keep
                }
            }

                return nextElement;
        }
    }
}
