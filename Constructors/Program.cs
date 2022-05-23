using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User(1,"Miray", "Adar", "İzmir");

            User user1 = new User() { UserId = 2, UserName = "Vildan", UserSurname = "Orhan", City = "İzmir" }; // 2 türlü de tanımlanabilir

            Console.WriteLine(user.UserSurname);
        
        }
    }
}
