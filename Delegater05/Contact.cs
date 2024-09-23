using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegater05
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Contact(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age; 
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName} {Age} ";
        }
    }
}
