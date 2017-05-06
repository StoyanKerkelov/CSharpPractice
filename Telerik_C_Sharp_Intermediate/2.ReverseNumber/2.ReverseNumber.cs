using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.ReverseNumber
{
    class Program
    {//Write a method that reverses the digits of a given decimal number.

        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            Console.WriteLine(ReversedNumber(number));
        }

        public static string ReversedNumber(string text)
        {      
     	    string reverse = String.Empty;
	        char[] cArray = text.ToCharArray();
            
            for (int i = cArray.Length - 1; i > -1; i--)
        	    {
                	reverse += cArray[i]; 
                }
            return reverse;
        }
    }
}







