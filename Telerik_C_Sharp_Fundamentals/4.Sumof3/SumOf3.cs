using System;


namespace _4.Sumof3
{
    class SumOf3
    {
        static void Main(string[] args)
        {
            decimal a = decimal.Parse(Console.ReadLine());
            decimal b = decimal.Parse(Console.ReadLine());
            decimal c = decimal.Parse(Console.ReadLine());
            //if  ((a<=1000 && a>=-1000 ) && (b <= 1000 && b >= -1000) && (b <= 1000 && b >= -1000))
            //    {
            //    Console.WriteLine("{}", a, b, c, a + b + c);
            //}
            Console.WriteLine("{3}", a, b, c, a + b + c);
        }
    }
}
