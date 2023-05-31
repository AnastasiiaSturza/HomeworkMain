namespace ConsoleApp20._05
{
    public class Lesson
    {
        public string Name { get; set; }
        public Student[] Students { get;set; }
        public Teacher Teacher { get; set; }
        public Room Room { get; set; }

        public Lesson(string name)  // cconstructor + less constuctor
        {
            Name = name;

        }
        public Lesson() { }

    }

}

