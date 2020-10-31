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
            string testString = ")}OJR 92ww. z )UPl 49e ]S  g. zrZEnQ  D. FoKp ]ow 1EceB 3oK }w ]CA? L 3LPbDN! trqJY 0sBmm. Nwn";
            //"jds dsaf lkdf kdsa fkldsf, adsbf ldka ads? asd bfdal ds bf[l. akf dhj ds 878 dwa WE DE 7475 dsfh ds RAMU 748 dj.";
            Program p = new Program();
            p.howMany2(testString);

        }


        //CONSTRAINTS: 0 < LENGTH OF INPUT STRING <= 10^5 
        public int howMany(string sentence)
        {
            long wordCount = 0;

            //Regex rx2 = new Regex(@"\-");
            //MatchCollection containsHyphens = rx2.Matches(sentence);
            //Console.WriteLine($"ContainsHyphens.Count is {containsHyphens.Count}");


            string[] words = sentence.Split(" ", ' ', StringSplitOptions.None);
            Console.WriteLine($"words.Length is {words.Length}");


            wordCount = words.Length;

            foreach (string s in words)
            {
                //if(s.Contains('0' || '1' || '2' || '3' || '4' || '5' || '6' || '7' || '8' || '9' ||'[' || ']' || '{' || '}' || '=' || '+' || ')' || '(' || '*' || '&' || '^' || '%' || '$' || '#' || '@' || '>' || '<' || '`'|| '~'))
                //{
                //    wordCount--;
                //}
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
            return Convert.ToInt32(wordCount);
        }

        public int howMany2(string sentence)
        {
            int wordCount = 0;

            string[] words = sentence.Split(new char[] { ' ' });
            
            //string[] words = sentence.Split(new char[] { ' ' });
            Console.WriteLine($"words.Length is {words.Length}");
            


            foreach (string s in words)
            {
                if(s.Trim() != "")
                {
                    wordCount++;        
                }


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