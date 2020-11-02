using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;

namespace SlotMachine2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<string> testInput = new List<string> { "4", "712", "246", "365", "312" };
            Program p = new Program();
            p.slotWheels(testInput);


        }

        /*
    * Complete the 'slotWheels' function below.
    *
    * The function is expected to return an INTEGER.
    * The function accepts STRING_ARRAY history as parameter.
    */

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

            for (int spin = 1; spin < history.Count; spin++)
            {
                //find the largest number in the dictionary
                biggestMapDigit = (int)spinMap.Keys.Max();
                Console.WriteLine($"biggestKeyInMap is {biggestMapDigit}");
                //add that number to totalSpins
                totalSpins += biggestMapDigit;

                //now find and remove the largest number in each row of the list from the dictionary
                char[] digits = history[spin].ToCharArray();
                List<double> numList = new List<double>();
                
                double biggestNum = 0;

                foreach (char d in digits)
                {
                    numList.Add(char.GetNumericValue(d));
                    
                }

                biggestNum = numList.Max();
                Console.WriteLine($"the biggest num in the row is {biggestNum}");
                
                if (spinMap[biggestNum] == 1)
                    {
                        spinMap.Remove(biggestNum);
                    }
                    else
                    {
                        spinMap[biggestNum] -= 1;
                    }
                    
            }
             
            return totalSpins;
        }
    }
}

                //from x in spinMap
                    //where x.Key == spinMap.Max(x => x.Key)
                    //select x.Key;
