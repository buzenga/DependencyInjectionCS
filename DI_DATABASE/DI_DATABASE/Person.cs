using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_DATABASE
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Profession { get; set; } 

        public Person(int id, string firstName, string lastName, string profession)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Profession = profession;
        }
    }
}
