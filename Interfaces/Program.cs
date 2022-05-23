using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
           //IPersonManager customerManager = new CustomerManager();
            //customerManager.Update();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new InternManager());



        }
    }
    // inherits - class --------------- implements - interfaces
 
    interface IPersonManager
    {
        //unimplemented operation
        void Add();
        void Update();
    }
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Müşteri eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Müşteri güncellendi");
        }
    }

    class PersonelManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Personel eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Personel güncellendi");
        }
    }

    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Stajyer eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Stajyer güncellendi");
        }
    }

    class ProjectManager
    {
        public void Add(IPersonManager personManager) {
            personManager.Add();
        }
    }
}
