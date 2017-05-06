using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.ParseURL
{
    class Program
    {
        //Write a program that parses an URL address given in the format: 
        //[protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
        //On the only line you will receive an address

        static void Main()
        {
            string input = @"http://telerikacademy.com/Courses/Courses/Details/212";
            //Console.WriteLine("Write the side's URL");string input = Console.ReadLine();        
            StringBuilder protocol = new StringBuilder();
            StringBuilder server = new StringBuilder();
            StringBuilder resourse = new StringBuilder();
            char delimeter = '/';
            int protocolEndIndex = 0, serverEndIndex = 0;

            protocolEndIndex = input.IndexOf(':');
            serverEndIndex = input.IndexOf(delimeter, protocolEndIndex + 3);//server name between :// and first next /

            for (int counter = 0; counter < protocolEndIndex; counter++)
            {
                protocol.Append(input[counter]);    // build protocol StringBuilder
            }

            for (int counter = protocolEndIndex + 3; counter < serverEndIndex; counter++)
            {
                server.Append(input[counter]);      //build server StringBuilder after protocol StringBuilder
            }

            for (int counter = serverEndIndex; counter < input.Length; counter++)
            {
                resourse.Append(input[counter]);    //build resourse StringBuilder after resourse StringBuilder
            }
            //Console.WriteLine("Original URL: \n{0}", input);
            Console.WriteLine("Parsed: ");
            Console.WriteLine("[protocol]: {0}", protocol.ToString());
            Console.WriteLine("[server]: {0}", server.ToString());
            Console.WriteLine("[resourse]: {0}", resourse.ToString());
        }
    }
}
