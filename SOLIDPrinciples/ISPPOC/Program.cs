using System;

namespace ISPPOC
{
    public interface ILead
    {
        void CreateSubTasks();
        void AssignTask();
        void WorkOnTask();
    }
    public class Lead : ILead
    {
        public void AssignTask()
        {
            Console.WriteLine("team lead can assign Tasks");
        }

        public void CreateSubTasks()
        {
            Console.WriteLine("team lead can create Tasks");
        }

        public void WorkOnTask()
        {
            Console.WriteLine("team lead can can work on Tasks");
        }
    }

    public class Manager : ILead
    {
        public void AssignTask()
        {
            Console.WriteLine("manager can assign Tasks");
        }

        public void CreateSubTasks()
        {
            Console.WriteLine("manager can create sub Tasks");
        }

        public void WorkOnTask()
        {
            Console.WriteLine("manager can't work on Task so it is voilates the ISP");
        }
    }

    public class Programmers : ILead
    {
        public void AssignTask()
        {
            Console.WriteLine("Programmer can't assign Tasks  it is voilates the ISP");
        }

        public void CreateSubTasks()
        {
            Console.WriteLine("Programmer can't create sub Tasks  it is voilates the ISP");
        }

        public void WorkOnTask()
        {
            Console.WriteLine("Programmer only work on Task ");
        }
    }

    public class Program
    {
        //static void Main(string[] args)
        //{
        //    Manager _ganesh = new Manager();
        //    Lead _suman = new Lead();
        //    Programmers _aditya = new Programmers();
        //    Console.WriteLine("Hello World!");
        //    Console.ReadKey();
        //}
    }
}
