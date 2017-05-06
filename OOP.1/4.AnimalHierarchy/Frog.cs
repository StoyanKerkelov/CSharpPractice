using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Frog : Animal, ISound
{
    public Frog(string name, byte age, Sex sex)
        : base(name, age, sex)
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine("{0} {1} says: Kvak-Kvak", this.GetType(), this.Name);
    }
}