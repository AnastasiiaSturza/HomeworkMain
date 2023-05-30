// student , teachers,  rooms, lessons

using ConsoleApp20._05;

var cathedra = new Cathedra
{
    Name = "Tech Cathedra",
    Teachers = new[]
    {
        new Teacher
        {
            Name = "John"
        },
        new Teacher
        {
            Name = "Marry"
        }
    },
    Groups = new[]
    {
        new Group
        {
            Name = "a1",
            Lessons = new[]
            {
                new Lesson
                {
                    Name = "Math"
                }
            }
        },

        new Group
        {
        Name ="A2",

        Lessons = new[]
        {
            new Lesson
            {
                Name = "English"
            }
        },

        Students = new[]
        {
            new Student
            {
            Name = "Andriy"
            }
        }
        }
    }
};
foreach (var group in cathedra.Groups)
{
    Console.WriteLine($"group name  : {group.Name}");

    Console.WriteLine();
}

