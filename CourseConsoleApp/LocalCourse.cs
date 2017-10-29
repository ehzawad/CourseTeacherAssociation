using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseConsoleApp
{
    public class LocalCourse : Course
    {
        private string labNumber;

        public string LabNumber
        {
            get => labNumber;
            set => labNumber = value;
        }

        public LocalCourse()
        {

        }

        public LocalCourse(string courseName,Teacher faculty, string labNumber)
        {
            this.courseName = courseName;
            this.courseFaculty = faculty;
            this.labNumber = labNumber;
        }

        public override string ToString()
        {
            var allValuesCommaSeperated = String.Join(", ", this.topics);
            return "CampusCourse: Name=" + this.courseName + "; "
                + "Teacher=" + this.courseFaculty.TeacherName +
                "; Topics=[" + allValuesCommaSeperated + "]; " +
                "Lab=" + this.labNumber;
                
        }
    }
}
