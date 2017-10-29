using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseConsoleApp
{
    public class OffsiteCourse : Course
    {
        private string town;

        public string Town
        {
            get => town;
            set => town = value;

        }

        public OffsiteCourse()
        {

        }

        public OffsiteCourse(string courseName, Teacher faculty, string town)
        {
            this.courseName = courseName;
            this.courseFaculty = faculty;
            this.town = town;
        }

        public override string ToString()
        {
            var allValuesCommaSeperated = String.Join(", ", this.topics);
            return "OffsiteCourse: Name=" + this.courseName + "; "
                + "Teacher=" + this.courseFaculty.TeacherName +
                "; Topics=[" + allValuesCommaSeperated + "]; " +
                "Lab=" + this.town;

        }
    }

}
