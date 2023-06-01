using System.ComponentModel;
using System.Text.RegularExpressions;

namespace ConsoleApp20._05
{
    public class Group
    {
        public string Name { get; set; }
        public Student[] Students { get; set; } = new Student[0];
        public Cathedra[] Cathedras { get; set; }
        public Lesson[] Lessons { get; set; } = new Lesson[0];
        // set cathedra  + add/ remove students/teachers + add/remove lessons
        public Group(string name)  // cconstructor + less constuctor
        {
            Name = name;

        }
        public Group(){ }
        public void AddStudent(Student group)   // method for add students to group ( create new group and add student)
        {
            Student[] addGroup = new Student[Students.Length + 1];

            for (int i = 0; i < Students.Length; i++)
            {

                addGroup[i] = Students[i];
            }
            addGroup[Students.Length] = group;

            Students = addGroup;
        }

        public void AddLesson(Lesson lessonNew)   // method for add lessons to group 
        {
            Lesson[] addGroup = new Lesson[Lessons.Length + 1];

            for (int i = 0; i < Lessons.Length; i++)
            {

                addGroup[i] = Lessons[i];
            }
            addGroup[Lessons.Length] = lessonNew;

            Lessons = addGroup;
        }

    }
}

