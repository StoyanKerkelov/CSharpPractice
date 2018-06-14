using System;

namespace _5.BonusScore
{
    class BonusScore
    {
        static void Main()
        {
            int score = int.Parse(Console.ReadLine());
            int print = score;

            if (score<1 || score>9)
            {
                Console.WriteLine("invalid score", print);
            }
            else if (score == 1 || score <= 3)
            {
                print *= 10; // multiple by 10
                Console.WriteLine("{0}", print);
            }
            else if (4 == score || score <= 6)
            {
                print *= 100; // multiple by 100
                Console.WriteLine("{0}", print);
            }
            else if (7 == score || score <= 9)
            {
                print *= 1000; // multiple by 1000
                Console.WriteLine("{0}", print);
            }
            
        }
    }
}
