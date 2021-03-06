﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Dog : Animal, ISound
{
    public Dog(string name, byte age, Sex sex)
        : base(name, age, sex)
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine("{0} {1} says: Woof-Woof", this.GetType(), this.Name);
    }
}