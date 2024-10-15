using CollectionsDemo.Models;

namespace CollectionsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Student student1 = new Student(1, "Allen", "ALlen@gmail.com");

            Student student2 = new Student(2, "Bob", "Bob@gmail.com");

           Subject subject1 = new Subject(101, "Java");
            subject1.Students.Add(student1);
            subject1.Students.Add(student2);

            Subject subject2 = new Subject(102, "DotNet");
            subject2.Students.Add(student1);

            // Creating professors and associating subjects
            Professor professor1 = new Professor(201, "Khannan");
            professor1.Subjects.Add(subject1);
            professor1.Subjects.Add(subject2);

            Professor professor2 = new Professor(202, "Swathi");
            professor2.Subjects.Add(subject2);

            // Creating a college and associating professors
            College college = new College("C01", "CBIT");
            college.ProfessorList.Add(professor1);
            college.ProfessorList.Add(professor2);

            Console.WriteLine("Based on College");
            Console.WriteLine(college.CollegeDetails());        
        }
    }
}

