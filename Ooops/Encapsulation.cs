using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ooops
{
    class Encapsulation
    {
        public void Login(string Username, string Password)
        {
            if (validate(Username, Password))
            {
                DBConnection();
                if (Authentication(Username, Password))
                {
                    Console.WriteLine("You have signed In");
                }
                else
                {
                    Console.WriteLine("Failed to Authenticate");
                }
            }
            else
            {
                Console.WriteLine(" Invalid Format");
            }
        }
        private bool validate(string Username, string Password)
        {
            // username should have morethan 3 & PASSWORD should contain alphanumerical characters 
            // Validate the Username and Password
            return true;
        }
        private bool DBConnection()
        {
            //  Establish Database Connection
            return true;
        }
        private bool Authentication(string Usernme,string Password)
        {
            if(Usernme == "Ramu" && Password ==" Raj@123")
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }
    }
}
