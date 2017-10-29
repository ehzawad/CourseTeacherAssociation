using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher stany = new Teacher("Victor Stany ROzario");

            // Campus Course
            LocalCourse oopTwo = new LocalCourse("OOP2", stany, "CL6");
            oopTwo.AddTopic("Property");
            oopTwo.AddTopic("Enumeration");
            Console.WriteLine(oopTwo.ToString());

            LocalCourse ooad = new LocalCourse("OOAD", stany, "CL10");
            ooad.AddTopic("Introduction to Modeling, UML, Use Case Diagram, Class Diagram");
            Console.WriteLine(ooad.ToString());

            // Offsite Course
            OffsiteCourse webTech = new OffsiteCourse("ASP.NET", stany, "Uttara");
            webTech.AddTopic("PHP, JSON, JS, NetWork Security");
            Console.WriteLine(webTech);



            // Checking Teacher Module
            Teacher csharpFaculty = new Teacher("Victor Stany Rozario");

            csharpFaculty.AddCourse(new Course("C#"));
            csharpFaculty.AddCourse(new Course("Java"));
            Console.WriteLine(csharpFaculty.ToString());

            Teacher osFaculty = new Teacher("Marzia Haque");
            osFaculty.AddCourse(new Course("OS"));
            Console.WriteLine(osFaculty.ToString());
        }
    }
}
