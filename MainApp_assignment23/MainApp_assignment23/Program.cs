using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySharedLibrary_assignment23;

namespace MainApp_assignment23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var userManagement = new UserManagement();
            userManagement.RegisterUser("example@example.com", "securepassword");
            Console.ReadKey();
        }
    }
}
