using System;

namespace LSPPOC
{
    public class Apple
    {
        public virtual string GetColor()
        {
            return "Red";
        }
    }
    public class Orange : Apple
    {
        public override string GetColor()
        {
            return "Orange";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Apple apple = new Orange();

            Console.WriteLine(apple.GetColor());
        }
    }
}
