using System;

namespace DeclareVariables
{
    class DeckareVariables
    {
        static void Main(string[] args)
        {
            byte byte_type = 97;
            sbyte sbyte_type = -115;
            short short_type = -10000;
            ushort ushort_type = 52130;
            int int_type = 482593212;
            uint uint_type = 482593212;
            float float_type = 34.567839023f;
            int hex_int_type = 0x100;
            char hex_char_type = '\u002A';
            bool IsFemale = false;
            string hello = "Hello";
            string world = "world!";
            Console.WriteLine(byte_type);
            Console.WriteLine(sbyte_type);
            Console.WriteLine(short_type);
            Console.WriteLine(ushort_type);
            Console.WriteLine(int_type);
            Console.WriteLine(uint_type);
            Console.WriteLine(float_type);
            Console.WriteLine(hex_int_type);
            Console.WriteLine(hex_char_type);
            Console.WriteLine(IsFemale);
            Console.WriteLine(hello + " " + world);
        }
    }
}
