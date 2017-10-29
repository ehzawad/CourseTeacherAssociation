using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseConsoleApp;

namespace CourseConsoleApp
{
    public class Teacher
    {
        private string teacherName;
        List<Course> holdCourses = new List<Course>();

        public Teacher()
        {

        }

        public Teacher(string teacherName)
        {
            this.teacherName = teacherName;
        }

        public string TeacherName
        {
            get => teacherName;
            set => teacherName = value;
        }

        public void AddCourse(Course course)
        {
            holdCourses.Add(course);
           
        }

        public override string ToString()
        {
            var allCoursesCommaSeperated = String.Join(", ", this.holdCourses);
            return "Teacher: Name=" + this.TeacherName + "; " +
                "Courses=[" + allCoursesCommaSeperated + "]";
        }
    }
}
