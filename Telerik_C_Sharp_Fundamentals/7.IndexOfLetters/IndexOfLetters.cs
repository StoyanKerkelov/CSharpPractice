using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.IndexOfLetters
{
    class IndexOfLetters
    {
        static void Main(string[] args)
        {

            string word = Console.ReadLine();

            /*foreach (char letter in word)
            {
                Console.WriteLine($"{letter - 'a'}");
            }*/

            for (int i = 0; i < word.Length; i++)
            {
                Console.WriteLine("{0}", (int)word[i] % 32 - 1);
            }
        }
    }
}
