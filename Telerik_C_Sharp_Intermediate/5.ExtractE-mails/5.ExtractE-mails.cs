using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _5.ExtractE_mails
{
    class Program
    {   //Write a program for extracting all email addresses from given text. 
        //All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails
        ////using Regex                         ([a-z0-9_\.-]+)  @([\da-z\.-]{2,})   \.([a-z\.]{2,6})
        static void Main()
        {   
            string regExEmailPatter = @"([a-z0-9_\.-]+)@([\da-z\.-]{2,})\.([a-z\.]{2,6})"; //Regex patter taken from http://net.tutsplus.com/tutorials/other/8-regular-expressions-you-should-know/. Modified to accept at least 2 symbols after "@".

            string sampleText = "Please contact us by phone (+359 222 222 222) or by email at example@abv.bg or at baj.ivan@yahoo.co.uk. This is not email: test@test. This also: @telerik.com. Neither this: a@a.b.";

            MatchCollection matches = Regex.Matches(sampleText, regExEmailPatter);//find matches of Regex in text

            Console.WriteLine("Text is: ");
            Console.WriteLine(sampleText);
            Console.WriteLine("\nIt contains following e-mails:\n");

            foreach (Match match in matches)
            {
                Console.WriteLine(match);
                Console.WriteLine();
            }
        }
    }
}
