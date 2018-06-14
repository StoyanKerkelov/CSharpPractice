using System;

namespace _6.PrintAFullDeck
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            char[] colors = { '\u2660', '\u2663', '\u2666', '\u2665' };

            string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

            foreach (var card in cards)
            {
                foreach (var color in colors)
                {
                    Console.Write(card + color);
                }

                Console.WriteLine();
            }

        }
    }
}
