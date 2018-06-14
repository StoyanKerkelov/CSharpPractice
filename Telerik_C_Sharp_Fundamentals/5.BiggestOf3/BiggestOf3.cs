using System;


namespace _5.BiggestOf3
{
    class BiggestOf3
    {
        static void Main()
        {
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());
            float max = Math.Max(a, Math.Max(b, c));
            Console.WriteLine(max);

        }
    }
}
