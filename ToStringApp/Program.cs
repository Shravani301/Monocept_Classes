using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToStringApp.Models;

namespace ToStringApp
{
    internal class Program
    {
        int instanceNumber;
        static int staticNumber;
        static void Main(string[] args)
        {
            Student student1= new Student(101,"Alice");
            Student student2 = new Student(102, "Bob");
            Student student3 = student2;

            //Console.WriteLine(student1==student2);
            //Console.WriteLine(student1.Equals(student2));
            //Console.WriteLine(student1==student3);
            //Console.WriteLine(student1.Equals(student3));
            //Console.WriteLine(student3==student2);
            //Console.WriteLine(student3.Equals(student2));

            Console.WriteLine(student1.ToString());

            Console.WriteLine(student1.GetHashCode());
            Console.WriteLine(student2.GetHashCode());
            Console.WriteLine(student3.GetHashCode()); 
            

            Program program=new Program();
            Console.WriteLine();
            Console.WriteLine("==== Static,Instance,Local Variables ====");
            Console.WriteLine();
            int localNumber=0;
            Console.WriteLine("Instance Varaible: "+ program.instanceNumber);
            Console.WriteLine("Static Varaible: "+staticNumber);
            Console.WriteLine("Local Variable: "+localNumber);

        }
    }
}
