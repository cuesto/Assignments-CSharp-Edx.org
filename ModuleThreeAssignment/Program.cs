using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleThreeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            GetStudentInfo();
            GetTeacherInfo();
            GetCourseInfo();
            GetProgramInfo();
            GetDegreeInfo();
            ValidateBirthday();
        }

        static void GetStudentInfo()
        {
            Console.WriteLine("Enter the student's first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the student's last name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter the student's birthday");
            string birthday = Console.ReadLine();
            PrintStudentDetails(firstName,lastName,birthday);
        }

        static void PrintStudentDetails(string first, string last, string birthday)
        {
            Console.WriteLine("{0} {1} was born on: {2}", first, last, birthday);
        }

        static void GetTeacherInfo()
        {
            Console.WriteLine("Enter the teacher's first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the teacher's last name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter the teacher's degree");
            string degree = Console.ReadLine();
            PrintTeacherDetails(firstName, lastName, degree);
        }

        static void PrintTeacherDetails(string first, string last, string degree)
        {
            Console.WriteLine("{0} {1} has a degree on: {2}", first, last, degree);
        }

        static void GetCourseInfo()
        {
            Console.WriteLine("Enter the course name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the course teacher name");
            string teacherName = Console.ReadLine();
            Console.WriteLine("Enter the course prerrequisite");
            string prerrequisite = Console.ReadLine();
            PrintCourseDetails(name, teacherName, prerrequisite);
        }

        static void PrintCourseDetails(string name, string teacherName, string prerrequisite)
        {
            Console.WriteLine("The {0} course wich teacher is {1} has this {2} prerrequisites", name, teacherName, prerrequisite);
        }

        static void GetProgramInfo()
        {
            Console.WriteLine("Enter the Program name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the schedule hour");
            string schedule = Console.ReadLine();
            Console.WriteLine("Enter the program prerrequisite");
            string prerrequisite = Console.ReadLine();
            PrintProgramDetails(name, schedule, prerrequisite);
        }

        static void PrintProgramDetails(string name, string schedule, string prerrequisite)
        {
            Console.WriteLine("The {0} Program wich schedule is {1} has this {2} prerrequisites", name, schedule, prerrequisite);
        }

        static void GetDegreeInfo()
        {
            Console.WriteLine("Enter the Degree name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the schedule hour");
            string schedule = Console.ReadLine();
            Console.WriteLine("Enter the Degree prerrequisite");
            string prerrequisite = Console.ReadLine();
            PrintDegreeDetails(name, schedule, prerrequisite);
        }

        static void PrintDegreeDetails(string name, string schedule, string prerrequisite)
        {
            Console.WriteLine("The {0} Degree wich schedule is {1} has this {2} prerrequisites", name, schedule, prerrequisite);
        }

        static void ValidateBirthday()
        {
            throw new NotImplementedException();
        }
    }
}
