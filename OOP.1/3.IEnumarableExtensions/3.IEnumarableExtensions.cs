using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Implement a set of extension methods for IEnumerable<T> that 
//implement the following group functions: sum, product, min, max, average.
class IEnumarableExtensions
{
    static void Main()
    {
        var collection = new List<int> { 100, 200, 129783, 12329083, 9831203 };

        Console.WriteLine(collection.Sum<int>());
        Console.WriteLine(collection.Average<int>());
        Console.WriteLine(collection.Product<int>());
        Console.WriteLine(collection.Min<int>());
    }
}
