using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo.Models
{
    internal class College
    {
        public string CollegeId { get; set; }
        public string CollegeName { get; set; }
        public List<Professor> ProfessorList { get; set; }

        public College(string collegeId, string collegeName)
        {
            CollegeId = collegeId;
            CollegeName = collegeName;
            ProfessorList = new List<Professor>();
        }

        public string CollegeDetails()
        {
            string result = $"College ID: {CollegeId}\n" +
                            $"College Name: {CollegeName}\n" +
                            $"--------Professors Details-------\n";
            foreach (Professor professor in ProfessorList)
            {
                result += professor.ProfessorDetails();
            }
            return result;
        }
    }
}
