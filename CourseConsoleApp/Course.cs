using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseConsoleApp
{
    public class Course
    {
        protected string courseName;
        protected Teacher courseFaculty;
        protected List<string> topics = new List<string>();

        public Course()
        {

        }

        public Course(string courseName)
        {
            this.courseName = courseName;
        }

        public Course(string courseName, Teacher faculty)
        {
            this.courseName = courseName;
            this.courseFaculty = faculty;
        }

        public virtual void AddTopic(string topic)
        {
            topics.Add(topic);
        }

        public virtual void AddTopics(string[] topics)
        {
            topics.Concat(topics);
        }

        public override string ToString()
        {
            return "" + this.courseName;
        }
    }
}
