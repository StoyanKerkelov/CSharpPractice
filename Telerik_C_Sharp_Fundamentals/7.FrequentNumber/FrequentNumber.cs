using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.FrequentNumber
{
    class FrequentNumber
    {
        static void Main()
        {

            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            //////////////////////////////////
            int number = 0;
            int most_rep_count = 0;

            var count_Dictionary = new Dictionary<int, int>();
            foreach (int element in array)
            {
                if (count_Dictionary.ContainsKey(element))
                {
                    count_Dictionary[element]++;
                }
                else
                {
                    count_Dictionary.Add(element, 1);
                }
            }
           
            foreach (KeyValuePair<int, int> pair in count_Dictionary)
            {
                if (pair.Value > most_rep_count)
                {
                    number = pair.Key;
                    most_rep_count = pair.Value;
                }
            }
            ///////////////////////////////////
            Console.WriteLine("{0} ({1} times)" ,number, most_rep_count);

        }
    }
}
