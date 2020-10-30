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
            
            Regex rx = new Regex(@"[a-zA-Z-]");
            rx.Match(sentence);


            Console.WriteLine($"allWords result is: {sentence}");

            Regex rx2 = new Regex(@"/\b -[a - zA - Z]/");
            int containsHyphens = rx2.Match(sentence).Length;
            Console.WriteLine($"containsHyphens result is: {containsHyphens}");

            //wordCount = allWords - containsHyphens;
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
