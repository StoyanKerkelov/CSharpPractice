using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOTO6_49
{
    class Program
    {
        public static int Count()
        {
            int first = 6;
            int second = 49;
            int sum = 1;
            for (int i = 1; i <= first; i++)
            {
                sum *= second;
                second--;
            }
            return sum;
        }

        /*public static int Combinations();
        {
            for (int i1 = 1; i1 <= 44; i1++)
                    {
                        for (int i2 = i1 + 1; i2 <= 45; i2++)
                        {
                            for (int i3 = i2 + 1; i3 <= 46; i3++)
                            {
                                for (int i4 = i3 + 1; i4 <= 47; i4++)
                                {
                                    for (int i5 = i4 + 1; i5 <= 48; i5++)
                                    {
                                        for (int i6 = i5 + 1; i6 <= 49; i6++)
                                        {
                                            return Console.WriteLine(i1 + " " + i2 + " " +
                                            i3 + " " + i4 + " " + i5 + " " + i6);

                                        }
                                    }
                                }
                            }
                        }
                    }
        }*/
        static void Main()
        {

            Console.WriteLine("Type y/n to find out how much are all posible 6/49 combinations");
            int choise = int.Parse(Console.ReadLine());
            if (choise == 1) //== 89 || choise == 121)
            {
                Count();
            }

            /*Console.WriteLine("All passable winning combinations of 6/49 are {0}", sum);

            Console.WriteLine("Type y/n if you want to see all 6/49 combinations");
            int choise2 = int.Parse(Console.ReadLine());

            if (choise2 == 89 || choise2 == 121)
            {*/

        }
    }
}




