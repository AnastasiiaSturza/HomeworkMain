using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classandHomeWork18._05
{
     public class PhoneBook
     {
       public  Person[] persons = new Person[0] ;

        public void addNewRecord(Person person)
        {
            Array.Resize(ref persons, persons.Length + 1);
            persons[persons.Length-1] = person;
        }

        public void ShowAll()
        {
            foreach(Person person in persons)
            {
                Console.WriteLine(person.GetInfo());
            }
        }
     }
}
