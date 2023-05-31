// student , teachers,  rooms, lessons

using ConsoleApp20._05;
using System.Diagnostics;

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
        new Lesson
        {
            Name = "a1",
            Lessons = new[]
            {
                new Lesson
                {
                    Name = "Math"
                }
            },
            Students = new[]
            {
                new Student
                {
                    Name = "Oleg Petrov"
                },
                new Student
                {
                    Name = "Evgeniy Makarenko"
                }


            }
        },

        new Lesson
        {
            Name = "A2",

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
                    Name = "Ivan Ivanov"
                },
                new Student
                {
                    Name = "Petro Petrov"
                }
            }

        }
    },
    Students = new[]
    {
        new Student
        {
            Name = "Artur Ivanov",
        },
        new Student
        {
            Name = "Andriy Petrov"
        },
        new Student
        {

            Name = "Ivan Gorbachev" //Console.ReadLine()
        }

    }
};
foreach (var g in cathedra.Groups)
{
    Console.WriteLine($"group name  : {g.Name}");
    foreach (var student in g.Students)
        Console.WriteLine($"student name : {student.Name}");

    Console.WriteLine();
}
Console.WriteLine("All teachers at cathedra: ");
foreach (var teacher in cathedra.Teachers)
{
    Console.WriteLine(teacher.Name);
    Console.WriteLine();
}
Console.WriteLine("All students at cathedra :");
foreach (var student in cathedra.Students)
{
    Console.WriteLine(student.Name);
    Console.WriteLine();

}
//Cathedra CreateCathedra(string name)
//{
//    var cathedra = new Cathedra
//    {
//        Name = name
//    };
//    return cathedra;
//}
//var cathedraName = "Cathedra of Math";
//Console.WriteLine(CreateCathedra(cathedraName).Name);
//Group CreatGroup(string name)
//{
//    var group = new Group
//    {
//        Name = name
//    };
//    return group;
//}
//var nameGroup = "AA22";
//Console.WriteLine(CreatGroup(nameGroup).Name);

//static Lesson CreateLesson(string name)
//{
//    var lesson = new Lesson
//    {
//        Name = name
//    };
//    return lesson;
//}
//var nameLesson = "Math";
//Console.WriteLine( CreateLesson(nameLesson).Name);

//static Student NewStudent (string name)
//{
//    var student = new Student
//    {
//        Name = name
//    };
//    return student;
//}

 
// add new groups to cathedra
var cathedra123 = new Cathedra("AAA");  // name cathedra (add new group here)
var group = new Lesson();
group.Name = "HHHH";
cathedra123.AddGroup(group);
Console.WriteLine();

//add new student and lesson to group
var groupNew = new Group("A22");
var student = new Student();
student.Name = "Anton fedorov";
groupNew.AddStudent(student);
var lessonNew = new Lesson("Math");
groupNew.AddLesson(lessonNew);
Console.WriteLine();








