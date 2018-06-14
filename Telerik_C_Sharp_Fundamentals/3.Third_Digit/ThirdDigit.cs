using System;

namespace Third_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int reminder = (N / 100) % 10;
            var output = reminder == 7 ? "true " : "false {0}";
            Console.WriteLine(output, reminder);
        }
    }
}
