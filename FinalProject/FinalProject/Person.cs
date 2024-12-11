using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Person
    {

        public Person( string fullName, string address, string email)
        {
           
            FullName = fullName;
            Address = address;
            Email = email;
        }

        public string FullName { get; set; }
        public string Address { get; set; } 
        public string Email { get; set; }   

    }
}
