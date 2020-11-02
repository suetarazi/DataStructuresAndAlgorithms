using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

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

            //need to go through and do the following for each spin:
            int spinRound = 1;
            int spinMax = Convert.ToInt32(history[0]);
    
            while(spinRound < spinMax)
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

                spinRound++;
            }
            return totalSpins;
        }
    }
}
