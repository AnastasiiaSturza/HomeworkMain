using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classandHomeWork18._05
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
        public int Age { get; set; }
        
        public string PhoneNumber { get; set; }


        public Person(string firstName, string lastName , string adress , int age, string phoneNumber) 
        { 
            FirstName = firstName;
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
            return $"{FirstName} {LastName} adress : {Adress} and age : {Age}";
        }
    }
}
