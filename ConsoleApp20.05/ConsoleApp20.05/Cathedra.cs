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

}

