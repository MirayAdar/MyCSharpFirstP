using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProject
{
    class CustomerService
    {
        List<Customer> customers;

        public CustomerService()
        {
               customers = new List<Customer>() {
               new Customer{Id= 0, FirstName = "Miray", LastName="Adar", City="İzmir", Email= "mirayadar@"},
               new Customer{Id= 0, FirstName = "Ata", LastName="Akalın ", City="İzmir", Email= "ata@"},
               new Customer{Id= 0, FirstName = "Vildan", LastName="Orhan", City="İzmir", Email= "vildan@"},
               new Customer{Id= 0, FirstName = "Muco", LastName="Adar", City="İzmir", Email= "muco@"},
            };
        }
        public List<Customer> GetAll()
        {
            // veritabanı bağlantısı
            return customers;
        }

        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }
    }
}
