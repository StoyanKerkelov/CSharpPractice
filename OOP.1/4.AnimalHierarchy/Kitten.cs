using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Kitten : Animal, ISound
{
    public Kitten(string name, byte age)
        : base(name, age, Sex.Female)
    {

    }

    public override void MakeSound()
    {
        Console.WriteLine("{0} {1} says: Purr-Purr", this.GetType(), this.Name);
    }
}