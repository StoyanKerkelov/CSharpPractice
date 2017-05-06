using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.SearcingInStrings

{   //Task: Find all occurrences of a string within another string. Store the indices of those occurrences in a List<int>.
    class Program
    {
        static List<int> FindOccurrences(string text, string word)
        {
            var indices = new List<int>();

            int indexOfNextBacon = text.IndexOf(word);//first ondex of occurence

            while (indexOfNextBacon != -1)//loop to end
            {
                indices.Add(indexOfNextBacon);//save every index
                indexOfNextBacon = text.IndexOf(word, indexOfNextBacon + 1);// find next index
            }

            return indices;
        }

        static void Main()
        {
            var text = @"bacon ipsum dolor amet kevin strip steak bacon bresaola shankle leberkas bacon turducken short ribs bacon meatball boudin capicola ribeye. T-bone corned beef filet mignon shankle, leberkas pastrami picanha rump chuck kevin tri-tip drumstick flank. Bacon beef ribs beef, shankle salami bresaola turkey swine brisket. Sirloin rump short ribs ground round chuck pork chop, boudin pork. Tail tongue prosciutto t-bone kielbasa shoulder rump, pastrami porchetta pork chop pork belly strip steak shankle pig. Salami prosciutto pork loin cupim bacon kielbasa doner. bacon";
            var text2 = "gg b gg pesho ivan gg";
            var indices = FindOccurrences(text2, "g");

            Console.WriteLine(text2.LastIndexOf("gg", 10));
        }
    }
}