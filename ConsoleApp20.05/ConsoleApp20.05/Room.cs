using System.Xml.Linq;

namespace ConsoleApp20._05
{
    public class Room
    {
        public string Name { get; set; }
        public Teacher Teacher { get; set;} 
        public Lesson Lesson { get; set;}

        public Room(string name)  // cconstructor + less constuctor
        {
            Name = name;

        }
        public Room() { }

    }
}

