using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleFourAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[5];

            for(int i = 0 ; i < 5 ; i++)
            {
                students[i].name = "Jonathan";
                Console.WriteLine(students[i].name);
            }
        }

        public struct Student
        {
            public string name { get; set; }
            public int age { get; set; }
        }

        public struct Teacher
        {
            public string name { get; set; }
            public string speciality { get; set; }
        }

        public struct program
        {
            public string name { get; set; }
            public string schedule { get; set; }
        }

        public struct Course
        {
            public string name { get; set; }
            public string prerrequisite { get; set; }
        }
    }
}
