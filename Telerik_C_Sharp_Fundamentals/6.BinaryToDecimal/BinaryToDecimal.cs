using System;


namespace _6.BinaryToDecimal
{
    class BinaryToDecimal
    {
        static void Main()
        {
            string binaryStr = Console.ReadLine();
            byte[] binarics = new byte[binaryStr.Length];// init binarics[] array with 'binaryStr' length
            for (int i = 0; i < binaryStr.Length; i++)
            {                                                               // for every i-th key, parse array member from
                binarics[i] = byte.Parse(Convert.ToString((binaryStr[i]))); // binaryStr
            }
            Array.Reverse(binarics);// reverse the order of the members from 'binarics' array

            long numDecimal = 0;        //result integer
            long multiplier = 1;        // power of 2
            foreach (var digit in binarics)
            {
                numDecimal += (digit * multiplier);
                multiplier *= 2;
            }

            Console.WriteLine("{0}", numDecimal);

        }
    }
}
