using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp20._05
{
    public class Cathedra
    {
        public string Name { get; set; }
        public Lesson[] Groups { get; set; } = new Lesson[0];

        public Teacher[] Teachers { get; set; }
         public Student[] Students { get; set; }
        public Lesson[] Lessons { get; set; }

        

        public Cathedra(string name)  // cconstructor + less constuctor
        {
            Name = name;
           
        }

        public Cathedra() { }
        public void  AddGroup(Lesson group)   // method for add group to cathedra ( create new cathera and add group)
        {
            Lesson[] addGroup = new Lesson[Groups.Length + 1];

            for (int i = 0; i < Groups.Length; i++)
            {

                addGroup[i] = Groups[i];
            }
            addGroup[Groups.Length] = group;

            Groups = addGroup;
        }



    }
    
}

