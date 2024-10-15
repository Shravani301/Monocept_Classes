using StudentBuddy.Models;

namespace StudentBuddy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student(1, "Allen", "ALlen@gmail.com");

            Student student2 = new Student(2, "Bob", "Bob@gmail.com");
            Student student3 = new Student(3, "Kate", "kate@gmail.com");

            Student student4 = new Student(4, "Mary", "Mary@gmail.com");

            Student.AddStudent(student1);
            Student.AddStudent(student2);
            Student.AddStudent(student3);
            Student.AddStudent(student4);
            
            Student.PrintStudents(student1);
            Student.PrintStudents(student2);
            Student.PrintStudents(student3);
            Student.PrintStudents(student4);

        }
    }
}
