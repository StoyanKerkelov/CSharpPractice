using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DefineClass
{
    class MobilePhoneTest
    {
        public void RunTests()
        {
            MobilePhone myMobilePhone = new MobilePhone("Moto G", "Motorola", 200, "Me");
            MobilePhone yourMobilePhone = new MobilePhone("M9", "HTC", 1000, "Someone else", new Battery("HTC Battery", 109, 400, BatteryType.LiIon));
            MobilePhone herMobilePhone = new MobilePhone("Lumia", "Microsoft", 500, "Jane Doe", new Battery("Microsoft Battery", 87, 234, BatteryType.NiMH), new Display(10));
            MobilePhone hisMobilePhone = new MobilePhone("One", "OnePlus", 300, "i don't care in chinese", new Battery("Some Battery", 123, 265, BatteryType.LiPoly), new Display(13, 16000000));
            MobilePhone theirMobilePhone = new MobilePhone("Note 2", "Samsung", 100, "some asshole");

            MobilePhone[] phones = { myMobilePhone, yourMobilePhone, herMobilePhone, hisMobilePhone, theirMobilePhone };

            foreach (var phone in phones)
            {
                Console.WriteLine(phone.ToString());
                Console.WriteLine(new string('-', 35));
            }

            Console.WriteLine(MobilePhone.IPhone7.ToString());
        }
    }
}