using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Censorship
{
    class Program
    {
        static void Main()
        {
            // obscure a set of given words from an article
            // real life example: remove swearword from a forum post

            var censorshipSymbols = "!@#$%^&*_+/*<>/?";

            var swearWords = new string[]
            {
                "bau",
                "mqu",
                "coo",
                "pur",
                "FAQ",
                "batal",
                "programist",
                "kraen avtomat",
                "rekursiq"
            };

            var forumPost = @"Dokato si vodeh lekciqta reshihme da coo mqu kotkata pravq
                            ili mqu ili cur i pur ako e na skarata 
                            workshop po rekursiq - iok 
                            read FAQ before asking dumb question 
                            programist program batal battle ships cookie";

            foreach (var swear in swearWords)
            {
                forumPost = forumPost.Replace(swear, censorshipSymbols.Substring(0, swear.Length));
            }

            Console.WriteLine(forumPost);
        }
    }
}
