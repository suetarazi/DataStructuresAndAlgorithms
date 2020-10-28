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

        public int removeKey(int[] arr, int key)
        {
            int indexTracker = 0;

            for (int i = 0; i < arr.Length; i++)
            {

            }

                return indexTracker;
        }
    }
}
