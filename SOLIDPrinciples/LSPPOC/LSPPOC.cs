using System;
using System.Collections.Generic;
using System.Text;

namespace LSPPOC
{
    public abstract class Fruit
    {
        public abstract string GetColor();
    }

    public class Apples : Fruit
    {
        public override string GetColor()
        {
            return "Red";
        }
    }

    public class Oranges : Fruit
    {
        public override string GetColor()
        {
            return "Orange";
        }
    }

    class LSPPOC
    {
        public static void Main()
        {
            Fruit fruit = new Oranges();
            Console.WriteLine(fruit.GetColor());
            fruit = new Apples();
            Console.WriteLine(fruit.GetColor());
            Console.ReadKey();
        }
    }
}
