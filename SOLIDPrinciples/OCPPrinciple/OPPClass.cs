using System;
using System.Collections.Generic;
using System.Text;

namespace OCPPrinciple
{
    public abstract class Animal
    {
        public abstract string Speak();
    }

    public class Dog : Animal
    {
        public override string Speak()
        {
            return "Berk berak";
        }
    }

    public class Lion : Animal
    {
        public override string Speak()
        {
            return "Roar";
        
        }
    }

    public class AnimalFactory
    {
        public Animal GetAnimal(string animalType)
        {
            if (animalType.Equals("Dog"))
            {
                return new Dog();
            }
            else if (animalType.Equals("Lion"))
            {
                return new Lion();
            }
            else
                return null;
        }

    }

    //public class OPPClass
    //{
    //    public static void Main()
    //    {
    //        var speak = new AnimalFactory().GetAnimal("Dog");
    //        Console.WriteLine(speak.GetType().Name + "speaks :" + speak.Speak());
    //        Console.ReadKey();
    //    }
    //}
}
