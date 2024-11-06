namespace LinQDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>() { "shravani", "shirisha","Sneha","Chandana" };
            var filteredNames=names.Where(name=>name.Contains("h")).Select(name=>name.ToLower()).ToList();
            foreach (var name in filteredNames)
            {
                Console.WriteLine(name);
            }

            List<int> numbers= new List<int>() { 10,20,30,40,50};
            Console.WriteLine(numbers.Count);
            Console.WriteLine(numbers.Max());
            Console.WriteLine(numbers.Min());
            Console.WriteLine(numbers.Sum());
            Console.WriteLine(numbers.Average());

            List<Student> students = new List<Student>()
            {
                new Student(){ ID=101,Name="Shravani",Address="Hyd"},
                new Student(){ ID=103,Name="Shravani",Address="Wgl"},
                 new Student(){ ID=102,Name="Shirisha",Address="Knr"},
            };
            var name1=students.Where(student=>student.Address=="Hyd").FirstOrDefault().Name;
            Console.WriteLine(name1);

            var name2 = from student in students
                       where student.Address == "Hyd" 
                select student.Name;
            Console.WriteLine(name2.FirstOrDefault());

            students.OrderBy(student=>student.Name).ThenBy(student=>student.Address).ToList().
                ForEach(student=>Console.WriteLine(student.Name+" : "+student.Address));


            List<int> numbers1= new List<int>() { 10,30,23,56,50,89,3,4};
            Console.WriteLine("Take first5:");
            numbers1.Take(5).ToList().ForEach(n=>Console.WriteLine(n));
            Console.WriteLine("TaskeLast5:");
            numbers1.TakeLast(5).ToList().ForEach((n)=>Console.WriteLine(n));
            Console.WriteLine("TakeWhile Even:");
            numbers1.TakeWhile(n=>n%2==0).ToList().ForEach(n=>Console.WriteLine(n));
            Console.WriteLine("Skip 2");
            numbers1.Skip(2).ToList().ForEach(n=>Console.WriteLine(n));
            Console.WriteLine("Skiplast2");
            numbers1.SkipLast(2).ToList().ForEach (n=>Console.WriteLine(n));
            Console.WriteLine("SkipWhileEven");
            numbers1.SkipWhile(n=>n%2==0).ToList().ForEach ((n)=>Console.WriteLine(n));


        }
    }
}
