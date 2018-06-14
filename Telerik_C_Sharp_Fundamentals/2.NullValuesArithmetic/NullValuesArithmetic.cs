using System;

namespace NullValuesArithmetic
{
    class NullValuesArithmetic
    {
        static void Main(string[] args)
        {
            //Nullable types can represent all the values of an underlying type,
            //and an additional null value. declaring: "T? variable"
            int? int_type = null;
            double? double_type = null;
            Console.WriteLine(int_type);
            Console.WriteLine(double_type);
            Console.WriteLine("after adding value to the varaliables:");
            Console.WriteLine(int_type=5);
            Console.WriteLine(double_type=5.1234);
        }
    }
}
