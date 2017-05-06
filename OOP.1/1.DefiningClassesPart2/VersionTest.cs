using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DefiningClassesPart2
{
    class VersionTest
    {
        public static void RunTests()
        {
            Type type = typeof(VersionTest);
            object[] allAttributes = type.GetCustomAttributes(false);

            foreach (VersionAttributes attribute in allAttributes)
            {
                Console.WriteLine("Version {0}.{1}", attribute.Major, attribute.Minor);
            }
        }
    }
}