using ManyToManyDemo.Controllers;

namespace ManyToManyDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CourseController courseController = new CourseController();
            StudentController studentController=new StudentController();
            //studentController.GetAllStudents();
            //courseController.AddCourse();
            //courseController.GetAllCourses();
            //studentController.AddAndEnrollStudent();
            //studentController.EnrollStudent();
            studentController.TransferStudentCourse();
        }
    }
}
