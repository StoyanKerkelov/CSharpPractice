using System;

namespace _5.MultiplicationSign
{
    class MultiplicationSign
    {
        static void Main(string[] args)
        {
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double c = double.Parse(Console.ReadLine());

                if (a < 0)
                {
                    if (b < 0)
                    {
                        if (c < 0)
                        {
                            Console.WriteLine("-");//a- b- c-
                        }
                        else
                        {
                            Console.WriteLine("+");//a- b- c+
                        }
                    }
                    else
                    {
                        if (c < 0)
                        {
                            Console.WriteLine("+");//a- b+ c-
                        }
                        else
                        {
                            Console.WriteLine("-");//a- b+ c+
                        }
                    }
                }
                else if (a > 0)
                {
                    if (b < 0)
                    {
                        if (c < 0)
                        {
                            Console.WriteLine("+");//a+ b- c-
                        }
                        else
                        {
                            Console.WriteLine("-");//a+ b- c+
                        }
                    }
                    else
                    {
                        if (c < 0)
                        {
                            Console.WriteLine("-");//a+ b+ c-
                        }
                        else
                        {
                            Console.WriteLine("+");//a+ b+ c-
                        }
                    }
                }
                else if ((a == 0) || (b == 0) || (c == 0))
                {
                    Console.WriteLine("0");
                }
            }


        }
    }
}
