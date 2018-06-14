using System;

namespace Loop1000
{
    class Loop1000
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 1001; i++)
            {
                Console.WriteLine(i);
                printDash();
            }

        }

        private static void printDash()
        {
            Console.WriteLine("-");
        }
    }
}
