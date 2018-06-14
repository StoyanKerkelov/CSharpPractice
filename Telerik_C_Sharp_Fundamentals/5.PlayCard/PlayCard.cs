using System;
using System.Linq;

namespace _5.PlayCard
{
    class PlayCard
    {
        static void Main()
        {
           // char[] ardeck = { '2', '3', '4', '5', '6', '7', '8', '9', '10', 'J', 'Q', 'K', 'A' };

            string string_deck = "2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K, A";
            string str_card = Console.ReadLine();
            
            if (string_deck.Contains(str_card))
                {
                Console.WriteLine("yes {0}", str_card);
            }
            else
            {
                Console.WriteLine("no {0}", str_card);
            }
                            
        }
    }
}
