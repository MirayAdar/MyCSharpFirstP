using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class User
    {

        public User(int id, string name, string surname, string city)
        {
            UserId = id;
            UserName = name;
            UserSurname = surname;
            City = city;
        }
        public User()  // overloading
        {
            Console.WriteLine("Constructor çalıştı");
        }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserSurname { get; set; }
        public string City { get; set; }
    }
}
