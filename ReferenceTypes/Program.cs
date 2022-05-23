using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // int, decimal, float, enum, boolean value types
            // arrays,class, interface.. reference types

            //int[] sayilar1 = new int[] { 1, 2, 3 };
            //int[] sayilar2 = new int[] { 10, 20, 30 };

            //sayilar1 = sayilar2;
            //sayilar2[0] = 1000;

            //Console.WriteLine(sayilar1[0]); // 1000 değeri gelir (stack-heap yapısından dolayı 101 adres numarasını tutan kalmadı)

            PersonService personService = new PersonService();
            Customer customer1 = new Customer();
            customer1.FirstName = "Miray";
            customer1.CreditCardNumber = 1215662288;
            Employee employee = new Employee() { FirstName = "Berke" };
            Person person1 = new Person();
            person1 = customer1;    // Person customer'ın da employee'nin de adresini tutabiliyor (base class olduğu için)
            person1.FirstName = "Vildan";
            Console.WriteLine(customer1.FirstName);
            Console.WriteLine(((Customer)person1).CreditCardNumber);
            personService.Add(employee);
        }
    }

    class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        class Customer : Person
        {
            public int CreditCardNumber { get; set; }
        }
      
        class Employee : Person
    {
        public int EmployeeNumber { get; set; }
    }

      class PersonService
    {

        public void Add(Person person)
        {
            Console.WriteLine("Kullanıcı eklendi: " + person.FirstName);
        }
    }
}
