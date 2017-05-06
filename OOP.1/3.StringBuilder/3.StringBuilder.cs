using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder 
//and has the same functionality as Substring in the class String.

class StringBuilderSubstring
{
    static void Main()
    {
        StringBuilder input = new StringBuilder();

        input.Append("Telerik");
        input.Append("Academy");

        Console.WriteLine(input.Substring(3, 5).ToString());
    }
}
