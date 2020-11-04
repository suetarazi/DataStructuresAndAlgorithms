using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;

namespace SlotMachine2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<string> testInput = new List<string> { "4", "1112", "1111", "1211", "1111" };
            Program p = new Program();
            p.slotWheels(testInput);


        }

        /*
    * Complete the 'slotWheels' function below.
    *
    * The function is expected to return an INTEGER.
    * The function accepts STRING_ARRAY history as parameter.
    */
        //find biggest number in each row -> rowResults[]
        //take largest number in rowResults and totalSpins += largest number found in rowResults
        //remove rowResults[] i.e. shrink the string results of each spin by their largest value

        public int slotWheels2(List<string> history)
        {
            int totalSpins = 0;
            int n = Convert.ToInt32(history[0]);
            int[,] arr = new int [n, history[1].Length];


            //make int list or array (history[1].Length);
            for (int spin = 1; spin < history.Count; spin++)
            {
                for(int num=0; num < history[1].Length; num++)
                {
                    arr[spin,num] = history[spin][num] - '0';

                }
            }

            //now sort each row in the 2-D array, then put it in descending order
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < history[1].Length; j++)
                    {
                        Array.Sort(arr);
                    Array.Reverse(arr);
                    }
            }
        
            for(int i = 0; i < n; i++)
            {
                int maxNum = arr[0, i];
                for(int k = 0; k < history[1].Length; k++)
                {
                    if(arr[k, i] > maxNum)
                    {
                        maxNum = arr[k, i];
                    }

                }

                totalSpins += maxNum;
            }
            
            return totalSpins;
        }


            //take in each slot spin and convert it from string to int array
            //find largest value in array 
            //create a variable to remember the largest value in the first row. then, for each subsequent row, if maxValue in that row is > stored maxValue; stored maxValue = the new maxValue in row
            //remove the maxValue found in each array
        public int slotWheels(List<string> history)
        {
            int totalSpins = 0;
            int biggestMapDigit = 0;
            Dictionary<double, int> spinMap = new Dictionary<double, int>();

            //Go through the list and put each digit into a HashMap (dictionary)
            for (int spin = 1; spin < history.Count; spin++)
            {
                char[] digits = history[spin].ToCharArray();
                foreach (char d in digits)
                {
                    double dNum = char.GetNumericValue(d);

                    Console.WriteLine($"the d char is: {d} and the dNum is {dNum}");


                    if (!spinMap.ContainsKey(dNum))
                    {
                        spinMap.Add(dNum, 1);
                    }
                    else
                    {
                        spinMap[dNum] += 1;
                    }

                }
            }

            //need to go through and do the following for each spin:
            int spinRound = 1;
            int spinMax = Convert.ToInt32(history[0]);
    
            while(spinRound <= spinMax)
            {
            if(spinMap != null)
                {

            //find the largest number in the dictionary
                biggestMapDigit = (int)spinMap.Keys.Max();
                Console.WriteLine($"biggestKeyInMap is {biggestMapDigit}");
                //add that number to totalSpins
                totalSpins += biggestMapDigit;


            for(int spin = 1; spin < history.Count; spin++)
            {
                //now find and remove the largest number in each row of the list from the dictionary
                char[] digits = history[spin].ToCharArray();
                List<double> numList = new List<double>();
                double biggestNum = 0;
                

                foreach (char d in digits)
                {
                    numList.Add(char.GetNumericValue(d));
                    Console.WriteLine($"this is being added to numList {char.GetNumericValue(d)} ");    
                }

                biggestNum = numList.Max();
                Console.WriteLine($"the biggest num in the row is {biggestNum}");
                
                if(spinMap != null)
                {

                    if (spinMap[biggestNum] == 1)
                    {
                    Console.WriteLine($"We are about to remove biggest num: {biggestNum}");
                        spinMap.Remove(biggestNum);
                        numList.Remove(biggestNum);
                    } 
                    else
                    {
                        spinMap[biggestNum] -= 1;
                        numList.Remove(biggestNum);
                    Console.WriteLine($"We just decremented biggestNum: {biggestNum}");
                    }
                }

                    StringBuilder sb = new StringBuilder();
                    foreach(double num in numList)
                    {
                        sb.Append(num).Append("");
                    }
                    history[spin] = sb.ToString();

                }
            }

                spinRound++;
            }
            return totalSpins;
        }
    }
}
