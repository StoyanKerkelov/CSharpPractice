using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.SayHello
{   //Write a method that asks the user for his name
    //and prints Hello, <name>!. Write a program to test this method.
    class Program
    {
        static void NameMethod(string name)
        {

            Console.WriteLine("Hallo "+name);

        }

        static void Main()
        {

            Console.WriteLine("Hey what's your name");
            string name = Console.ReadLine();
            NameMethod(name);
        }
    }
}
