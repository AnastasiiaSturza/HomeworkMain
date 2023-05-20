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
            Name= "Marry"
        }
    },
    Groups = new[]
    {
        new Group
        {
            Name = "a1"
        }
    },
    Students = new[]
    {
        new Student
        {

        }
    },
    Lessons = new[]
    {
        new Lesson
        {
            Name = "Math"
        }
    }
};
Console.WriteLine(cathedra);