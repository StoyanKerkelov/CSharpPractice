using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.ParseTags
{
    class Program
    {   //You are given a text. Write a program that changes the text in all regions
        //surrounded by the tags <upcase> and </upcase> to upper-case.
        static void Main()
        {
            //string text = @"We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
            string text = Console.ReadLine();
            string openingTag = @"<upcase>";
            string closingTag = @"</upcase>";
            int position = -1;
            int capitalizationStart = 0, capitalizationEnd = 0;
            string replacementText = String.Empty, 
                capitalizedText = String.Empty,
                normalText = String.Empty;

            //Console.WriteLine("Original text: \n{0}\n", text);

            while (text.IndexOf(openingTag, position + 1) != -1)//change text between tags one at a time
            {
                capitalizationStart = text.IndexOf(openingTag, position + 1) + openingTag.Length;//search for <upcase>
                capitalizationEnd = text.IndexOf(closingTag, position + 1);//search for </upcase>
                for (int counter = capitalizationStart; counter < capitalizationEnd; counter++)//first text between <upcase> and </upcase>
                {
                    capitalizedText += Char.ToUpper(text[counter]).ToString();// make capital copy
                    normalText += text[counter].ToString();//identify texts without tags
                }

                text = text.Replace(openingTag + normalText + closingTag, capitalizedText);// replace the text between tags from the 
                                                                                            //old text
                position++;//move to next i
                capitalizedText = String.Empty;//emty partition
            }

            Console.WriteLine("Text with tags replaced: \n{0}\n", text);
        }
    }
}
