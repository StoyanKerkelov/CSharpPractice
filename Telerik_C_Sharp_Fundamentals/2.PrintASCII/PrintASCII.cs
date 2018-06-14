using System;

namespace PrintASCII
{
    class PrintASCII
    {
        static void Main()
        {
            string text = null;
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            for (int i = 33; i <= 126; i++)
            {
                text = text + (char)i;
            }
            System.Console.WriteLine(text);
        }
    }
}
 