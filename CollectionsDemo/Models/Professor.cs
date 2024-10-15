using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CollectionsDemo.Models
{
    internal class Professor
    {
        public int ProfessorId { get; set; }
        public string ProfessorName { get; set; }

        public List<Subject> Subjects { get; set; }

        public Professor(int professorId, string professorName)
        {
            ProfessorId = professorId;
            ProfessorName = professorName;
            Subjects = new List<Subject>();
        }

        public string ProfessorDetails()
        {
            string result = $"Professor ID: {ProfessorId}\n" +
                            $"Professor Name: {ProfessorName}\n" +
                            $"--------Subject Details-------\n";
            foreach (Subject subject in Subjects)
            {
                result += subject.SubjectDetails();
            }
            return result;
        }
    }
}
