using GenericsDemo.Models;

namespace GenericsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student(101,"Shirisha",45);
            Student student2= new Student(102, "Shravani", 48);
            Student student3 = new Student(103, "Snehalatha", 47);
            Student student4 = student2;
            Student student5 = new Student(103, "Snehalatha", 47);

            HashSet<Student> students = [student1, student2, student3,student4,student5];
            
            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }

      
            Dictionary<int,double> studentsDict = new Dictionary<int,double>();
            studentsDict.Add(student1.Id, student1.Marks);
            studentsDict.Add(student2.Id, student2.Marks);   
            studentsDict.Add(student3.Id, student3.Marks);
            
        }
    }
}
