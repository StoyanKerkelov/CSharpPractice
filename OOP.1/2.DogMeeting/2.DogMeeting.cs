using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.DogMeeting
{
    class chubaka
    {
        static void Main()
        {
            string firstDogName = null;
            Console.WriteLine("Write first dog name: ");
            firstDogName = Console.ReadLine();
            // Using a constructor to create a dog with specified name
            Dog firstDog = new Dog(firstDogName);
            // Using a constructor to create a dog with a default name
            Dog secondDog = new Dog();
            Console.WriteLine("Write second dog name: ");
            string secondDogName = Console.ReadLine();
            // Using property to set the name of the dog
            secondDog.Name = secondDogName;
            // Creating a dog with a default name
            Dog thirdDog = new Dog();
            Dog[] dogs = new Dog[] { firstDog, secondDog, thirdDog };
            foreach (Dog dog in dogs)
            {
                dog.Bark();
            }
        }
    }
}
