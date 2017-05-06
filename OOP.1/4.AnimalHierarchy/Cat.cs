using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Cat : Animal, ISound
{
    public Cat(string name, byte age, Sex sex)
        : base(name, age, sex)
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine("{0} {1} says: Meow-Meow", this.GetType(), this.Name);
    }
}