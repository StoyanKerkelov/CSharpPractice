using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLI
{
    class CLI
    {
        static void Main(string[] args)
        {
            int sum = 0;
            List<int> input = Console.ReadLine().Split(' ').Select(p => int.Parse(p)).ToList();
            for (int i = 0; i < (input.Count() - 1); i++)
            {
                sum += input[i];
            }
            Console.Out.WriteLine(sum);
        }
    }
}
