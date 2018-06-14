using System;
namespace _4.CompanyInfo
{
    class CompanyInfo
    {
        static void Main()
        {
            string Company_name = Console.ReadLine();
            string Company_address = Console.ReadLine();
            string Phone_number = Console.ReadLine();
            string Fax_number = Console.ReadLine();
            string Web_site = Console.ReadLine();
            string Manager_first_name = Console.ReadLine();
            string Manager_last_name = Console.ReadLine();
            int Manager_age = int.Parse(Console.ReadLine());
            string Manager_phone = Console.ReadLine();

            Console.WriteLine("{0}", Company_name);
            Console.WriteLine("Address: {0}", Company_address);
            Console.WriteLine("Tel. {0}", Phone_number);
            if (string.IsNullOrEmpty(Fax_number))
                {
                    Console.WriteLine("Fax: (no fax)");
                }
                else
                {
                    Console.WriteLine("Fax: {0}", Fax_number);
                }
            Console.WriteLine("Web site: {0}", Web_site);
            Console.Write("Manager: {0} {1}", Manager_first_name, Manager_last_name);
            Console.Write(" " + "(age: {0}", Manager_age);
            Console.WriteLine("," + " " + "tel. {0})", Manager_phone);
        }
    }
}
