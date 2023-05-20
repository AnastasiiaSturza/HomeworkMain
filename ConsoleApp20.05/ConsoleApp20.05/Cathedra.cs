using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp20._05
{
    public class Cathedra
    {
        public string Name { get; set; }
        public Group[] Groups { get; set; }

        public Teacher[] Teachers { get; set; }
         public Student[] Students { get; set; }
        public Lesson[] Lessons { get; set; }
    }

    public class Teacher
    {
        public string Name { get; set; }
        public Lesson[] Lessons { get; set; }
    }

    public class Group
     {
        public string Name { get; set; }
        public Student[] Students { get; set; }
        public Cathedra[] Cathedras { get; set; }
        public Lesson[] Lessons { get; set; }
        // set cathedra  + add/ remove students/teachers + add/remove lessons

     }
    
    public class Student
    {
        public string Name { get; set; }
        public Group Group { get; set; }
    }
   
    public class Lesson
    {
        public string Name { get; set; }
        public Student[] Students { get;set; }
        public Teacher Teacher { get; set; }
        public Room Room { get; set; }
    }

    public class Room
    {
        public Teacher Teacher { get; set;}
        public Lesson Lesson { get; set;}

    }
}

