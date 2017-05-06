using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.DogMeeting
{
    public class Dog// Class declaration
    { // Opening brace of the class body
      // Field declaration
        private string name;
        // Constructor declaration
        public Dog()
        {
            this.name = null;
        }
        // Another constructor declaration
        public Dog(string name)
        {
            this.name = name;
        }
        // Property declaration
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        // Method declaration
        public void Bark()
        {
            Console.WriteLine("{0} said: Wow-wow!", name);
        }
    }
}
