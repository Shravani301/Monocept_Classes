using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo.Models
{
    internal class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }

        public HashSet<Student> Students { get; set; }

        public Subject(int subjectId, string subjectName)
        {
            SubjectId = subjectId;
            SubjectName = subjectName;
            Students = new HashSet<Student>(); 
        }

        public string SubjectDetails()
        {
            string result = $"Subject ID: {SubjectId}\n" +
                            $"Subject Name: {SubjectName}\n" +
                            $"--------Students Details-------\n";
            foreach (Student student in Students)
            {
                result += student.ToString();
            }
            return result;
        }
    }
}
