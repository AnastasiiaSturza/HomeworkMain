using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClassWork18._05 //internal 
{
   public class Person
    { 
        public string variable { get; set; } // private
        public string FirstName { get; set;} // {get} without set - can make change only in constructor, for read only object
        public string LastName { get; set; }

        public string Adress { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        public Person( string firtName , string lastName, string adress, int age, string phoneNumber) 
        { 
            FirstName = firtName;
            LastName = lastName;
            Adress = adress;
            Age = age;
            PhoneNumber = phoneNumber;
        }
        public Person(Person person) 
        {
            FirstName = person.FirstName;
            LastName = person.LastName;
            Adress = person.Adress;
            Age = person.Age;
            PhoneNumber = person.PhoneNumber;
        }
        public void FullName()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }
        public string GetInfo()
        {
            return $"{FirstName} ,{LastName} , {Adress} ,{Age}";
        }
    }
}
