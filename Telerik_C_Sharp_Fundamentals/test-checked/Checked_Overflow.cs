using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_checked
{
    class Checked_Overflow
    {
        static void Main(string[] args)
        {
            double d = 5e9d; // 5 * 10^9 
            Console.WriteLine(d); // 5000000000 
            int i = checked((int)d); // System.OverflowException Console.WriteLine(i);
        }
    }
}
