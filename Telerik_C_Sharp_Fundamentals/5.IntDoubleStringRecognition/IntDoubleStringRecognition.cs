using System;


namespace _5.IntDoubleStringRecognition
{
    class IntDoubleStringRecognition
    {
        static void Main()
        {
            //int type = int.Parse(Console.ReadLine());
            string stype = Console.ReadLine();
            switch (stype)
            {
                case "integer":
                    int int_var = int.Parse(Console.ReadLine());
                    Console.WriteLine(int_var + 1);
                    break;
                case "real":
                    double double_var = double.Parse(Console.ReadLine());
                    //Console.WriteLine(double_var + 1.00);
                    Console.WriteLine("{0:0.00}",double_var + 1.00);
                    break;
                case "text":
                    string string_var = Console.ReadLine();
                    Console.WriteLine(string_var + "*");
                    break;
                default: Console.WriteLine("Not correct choice!"); break;




            }
        }
    }
}
