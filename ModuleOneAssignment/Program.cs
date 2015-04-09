using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleOneAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // variables of the program
            string firstName,
                lastName,
                address1,
                address2,
                city,
                state,
                country,
                professorName,
                universityDegree,
                programName,
                degreeOffered,
                deparmentHead,
                prerrequisites;
            int birthdate,zip;
            
            // assign values
            //firstName = "Jonathan";
            //lastName = "Cuesto";
            //address1 = "Sunflower Street";
            //address2 = "apartment 2b";
            //city = "Santo Domingo";
            //state = "Santo Domingo Oeste";
            //zip = 1809;
            //birthdate = 1991;
            //country = "Dominican Republic";
            //professorName = "Gerry O'Brien";
            //universityDegree = "Honor Certificate";
            //programName = "Programming with C#";
            //degreeOffered = "Honor Certificate";
            //deparmentHead = "IT";
            //prerrequisites = "C# knowledge";

            //read values from console
            Console.WriteLine("Enter the following informations ");
            Console.Write("First Name: ");
            firstName = Console.ReadLine();
            Console.Write("Last Name: ");
            lastName = Console.ReadLine();
            Console.Write("Address1: ");
            address1 = Console.ReadLine();
            Console.Write("Address2: ");
            address2 = Console.ReadLine();
            Console.Write("City: ");
            city = Console.ReadLine();
            Console.Write("State: ");
            state = Console.ReadLine();
            Console.Write("Zip: ");
            zip = Int32.Parse(Console.ReadLine());
            Console.Write("Birthday: ");
            birthdate = Int32.Parse(Console.ReadLine());
            Console.Write("Country: ");
            country = Console.ReadLine();
            Console.Write("Professor Name: ");
            professorName = Console.ReadLine();
            Console.Write("University Degree: ");
            universityDegree = Console.ReadLine();
            Console.Write("Program Name: ");
            programName = Console.ReadLine();
            Console.Write("Degree Offered: ");
            degreeOffered = Console.ReadLine();
            Console.Write("Department Head: ");
            deparmentHead = Console.ReadLine();
            Console.Write("Prerrequisites: ");
            prerrequisites = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Student Information:");
            Console.WriteLine("First Name: " + firstName);
            Console.WriteLine("Last Name: " + lastName);
            Console.WriteLine("Address 1: " + address1);
            Console.WriteLine("Address 2: " + address2);
            Console.WriteLine("City: " + city);
            Console.WriteLine("State: " + state);
            Console.WriteLine("Zip: " + zip);
            Console.WriteLine("Birthdate: " + birthdate);
            Console.WriteLine("Country: " + country);
            Console.WriteLine();
            Console.WriteLine("Teacher Information:");
            Console.WriteLine("Name: " + professorName);
            Console.WriteLine("University Degree: " + universityDegree);
            Console.WriteLine();
            Console.WriteLine("University Information:");
            Console.WriteLine("Program Name: " + programName);
            Console.WriteLine("Degree Offered: " + degreeOffered);
            Console.WriteLine("Department Head: " + deparmentHead);
            Console.WriteLine("Prerrequisites: " + prerrequisites);
        }
    }
}
