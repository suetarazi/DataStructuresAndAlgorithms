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
            string testString = "he is a good programmer, he won 865 competitions, but sometimes he dont. What do you think? All test-cases should pass. Done-done?";
            //"jds dsaf lkdf kdsa fkldsf, adsbf ldka ads? asd bfdal ds bf[l. akf dhj ds 878 dwa WE DE 7475 dsfh ds RAMU 748 dj.";
            Program p = new Program();
            p.howMany(testString);

        }

        public int howMany(string sentence)
        {
            int wordCount = 0;

            //Regex rx2 = new Regex(@"\-");
            //MatchCollection containsHyphens = rx2.Matches(sentence);
            //Console.WriteLine($"ContainsHyphens.Count is {containsHyphens.Count}");


            string[] words = sentence.Split(" ", ' ', StringSplitOptions.None);
            Console.WriteLine($"words.Length is {words.Length}");


            wordCount = words.Length;

            foreach (string s in words)
            {

                Regex rx3 = new Regex(@"\d|\[|\]|\{|\}|\=|\+|\)|\(|\*|\&|\^|\%|\$|\#|\@|\>|\<|\`|\~");
                MatchCollection charsNotAllowed = rx3.Matches(s);

                if (charsNotAllowed.Count != 0)
                {
                    Console.WriteLine($"This failed the if statement {s}!");
                    wordCount--;

                }

            }


            //wordCount -= containsHyphens.Count;
            //Console.WriteLine($"wordCount {wordCount} -= containsHyphens.Count {containsHyphens.Count}");

            Console.WriteLine($"wordCount is {wordCount}");
            return wordCount;
        }

        public int howMany2(string sentence)
        {
            int wordCount = 0;

            string[] words = sentence.Split(" ", ' ', StringSplitOptions.None);
            Console.WriteLine($"words.Length is {words.Length}");


            wordCount = words.Length;

            foreach (string s in words)
            {

                Regex rx3 = new Regex(@"\d|\[|\]|\{|\}|\=|\+|\)|\(|\*|\&|\^|\%|\$|\#|\@|\>|\<|\`|\~");
                MatchCollection charsNotAllowed = rx3.Matches(s);

                if (charsNotAllowed.Count != 0)
                {
                    Console.WriteLine($"This failed the if statement {s}!");
                    wordCount--;

                }

            }

            Console.WriteLine($"wordCount is {wordCount}");
            return wordCount;


        }
    }
}