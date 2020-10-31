using System;
using System.IO.Compression;
using System.Text.RegularExpressions;

namespace HowManyWords
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string testString = "How many eggs are in a half-dozen, 13?";
            Program p = new Program();
            p.howMany(testString);

        }

        public int howMany(string sentence)
        {
            int wordCount = 0;
            
            Regex rx = new Regex(@"\b[a-zA-Z]");
            MatchCollection allWords =  rx.Matches(sentence);
            

            for(int count = 0; count < allWords.Count; count++)
            {
                Console.WriteLine($"allWords result is: {allWords[count].Value}");
                Console.WriteLine($"the total count of allWords is {allWords.Count}");
            }

            Regex rx2 = new Regex(@"\-");
            MatchCollection containsHyphens = rx2.Matches(sentence);


            for(int count = 0; count < containsHyphens.Count; count++)
            {
                Console.WriteLine($"containsHyphens result is: {containsHyphens[count].Value}");
                Console.WriteLine($"the total count of hyphenated words is {containsHyphens.Count}");
            }

            wordCount = allWords.Count - containsHyphens.Count;
            Console.WriteLine($"wordCount is: {wordCount}");

            //string[] words = sentence.Split(" ");

            //foreach (string s in words)
            //{

            //    if (test != null)
            //    {
            //        wordCount++;

            //    }

            //return wordCount;
            //}

            return wordCount;
        }
    }
}
