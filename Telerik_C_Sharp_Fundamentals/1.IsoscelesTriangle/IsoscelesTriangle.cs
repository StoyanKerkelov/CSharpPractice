using System;

namespace IsoscelesTriangle
{
    class IsoscelesTriangle
    {
        static void Main()
        {
            char star = '\u002A';
            string visual_string = "   "+star+ "\n  " + star + " " + star + "\n " + star + "   " + star + "\n" + star + "  " + star + "  " + star + "";
            Console.WriteLine(visual_string);
        }
    }
}
