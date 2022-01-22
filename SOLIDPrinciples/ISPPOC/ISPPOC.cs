using System;
using System.Collections.Generic;
using System.Text;

namespace ISPPOC
{
    public interface IProgrammer
    {
        void WorkOnTask();
    }
    public interface ILeads
    {
        void DevideSubTask();
        void AssignTasks();
    }

    public class Programmer : IProgrammer
    {
        public void WorkOnTask()
        {
            Console.WriteLine("Programmer works on Task ");
        }
    }
    public class Managers : ILeads
    {
        public void AssignTasks()
        {
            Console.WriteLine("manager assign Tasks");
        }

        public void DevideSubTask()
        {
            Console.WriteLine("manager create sub Tasks");

        }
    }
    public class Leads : ILeads, IProgrammer
    {
        public void AssignTasks()
        {
            Console.WriteLine("team lead assign Tasks");

        }

        public void DevideSubTask()
        {
            Console.WriteLine("team lead create Tasks");
        }

        public void WorkOnTask()
        {
            Console.WriteLine("team lead can work on Tasks");
        }
    }

    class ISPPOC
    {
        public static void Main()
        {
            Managers _ganesh = new Managers();
            Leads _suman = new Leads();
            Programmer _aditya = new Programmer();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
