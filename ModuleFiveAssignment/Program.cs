using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;

namespace ModuleFiveAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            Student student2 = new Student();
            Student student3 = new Student();
            Course course = new Course();
            course.Name = "Programming with C#";
            course.SAs[0] = student1;
            course.SAs[1] = student2;
            course.SAs[2] = student3;
            Teacher teacher = new Teacher();
            course.As[0] = teacher;
            Degree degree = new Degree();
            degree.Name = "Bachelor";
            degree.Courses = course;
            UProgram uProgram = new UProgram();
            uProgram.Name = "Information Technology";
            uProgram.Degrees = degree;

            Console.WriteLine("The {0} program contains the {1} degree\n",uProgram.Name,uProgram.Degrees.Name);
            Console.WriteLine("The {0} degree contains the course {1}\n",uProgram.Degrees.Name, uProgram.Degrees.Courses.Name);
            Console.WriteLine("The {0} course contains {1} student(s)\n",uProgram.Degrees.Courses.Name,Student.sEnrolled);
        }
    }

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Birthday { get; set; }
        public static int sEnrolled;

        public Student()
        {
            sEnrolled++;
        }
    }

    class Teacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Degree { get; set; }
    }

    class UProgram
    {
        public string Name { get; set; }
        public string Schedule { get; set; }
        public string Prerrequisite { get; set; }
        public Degree Degrees { get; set; }
    }

    class Degree
    {
        public string Name { get; set; }
        public string Schedule { get; set; }
        public string Prerrequisite { get; set; }
        public Course Courses { get; set; }
    }

    class Course
    {
        public string Name { get; set; }
        public string TeacherName { get; set; }
        public string Prerrequisite { get; set; }

        public Teacher[] As
        {
            get { return TAs; }
            set { TAs = value; }
        }

        public Student[] SAs
        {
            get { return _sAs; }
            set { _sAs = value; }
        }

        Teacher[] TAs = new Teacher[3];
        Student[] _sAs = new Student[3];
    }
}
