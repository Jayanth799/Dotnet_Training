using System;

namespace AbstractFactoryDesign
{
  
        public interface Animal
        {
            string Speak();
        }

        public class Dog : Animal
        {
            public string Speak()
            {
                return "Berk berk";
            }
        }

        public class Cat : Animal
        {
            public string Speak()
            {
                return "Meow meow";
            }
        }

        public class Lion : Animal
        {
            public string Speak()
            {
                return "Roar";
            }
        }

        public class Octopus : Animal
        {
            public string Speak()
            {
                return "SQUAWCK";
            }
        }

        public class Shark : Animal
        {
            public string Speak()
            {
                return "Can not Speak";
            }
        }


        public abstract class AnimalFactory
        {
            public abstract Animal GetAnimal(string AnimalTypa);

            public static AnimalFactory CreateAnimalFactory(string FactoryType)
            {
                if (FactoryType.Equals("Sea"))
                {
                    return new SeaAnimalFactory();
                }
                else
                {
                    return new LandAanimalFactory();
                }
            }
        }

        public class LandAanimalFactory : AnimalFactory
        {
            public override Animal GetAnimal(string AnimalTypa)
            {
                if (AnimalTypa.Equals("Dog"))
                {
                    return new Dog();
                }
                else if (AnimalTypa.Equals("Cat"))
                {
                    return new Cat();
                }
                else if (AnimalTypa.Equals("Liom"))
                {
                    return new Lion();
                }
                else
                {
                    return null;
                }
            }
        }

        public class SeaAnimalFactory : AnimalFactory
        {
            public override Animal GetAnimal(string AnimalTypa)
            {
                if (AnimalTypa.Equals("Octopus")){
                    return new Octopus();
                }
                else if (AnimalTypa.Equals("Shark"))
                {
                    return new Shark();
                }    
                else
                {
                    return null;
                }
            }
        }
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = null;
            AnimalFactory animalFactory = null;
            string SpeakSound = null;
            animalFactory = AnimalFactory.CreateAnimalFactory("Sea");
            animal = animalFactory.GetAnimal("Shark");
            SpeakSound = animal.Speak();
            Console.WriteLine(SpeakSound);
        }
    }
}
