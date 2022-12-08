using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQPractice
{
    class Student
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public int Age { get; set; }
        public string Department { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentList=new List<Student>();
            studentList.Add(new Student { Id=101, Name="John", Age= 18, Department="Marketing"});
            studentList.Add(new Student { Id = 202, Name = "Lily", Age = 28, Department = "Finance" });
            studentList.Add(new Student { Id = 303, Name = "Jenny", Age = 23, Department = "Analytics" });
            studentList.Add(new Student { Id = 308, Name = "Stuart", Age = 19, Department = "E&C" });
            studentList.Add(new Student { Id = 404, Name = "George", Age = 19, Department = "IT" });

            Console.WriteLine("Select Statements\n");
            //var students = from student in studentList select student;  //Query expression
            var students = studentList.Select(x => x); //Method based
            foreach(var student in students)
            {
                Console.WriteLine(student.Id+" "+student.Name+" "+student.Age+" "+student.Department);
            }
            //var orderedStudents= from stu in studentList orderby stu.Name select stu;
            var orderedStudents = studentList.OrderBy(x => x.Age).ThenBy(x=>x.Name);
            Console.WriteLine("\nOrderBy\n");
            foreach(var student in orderedStudents)
            {
                Console.WriteLine(student.Age+" "+student.Name);
            }
            //var groupedStudents= from stud in studentList group stud by stud.Age;
            var groupedStudents=studentList.GroupBy(x => x.Age);
            Console.WriteLine("\nGroupBy\n");
            foreach(var student in groupedStudents)
            {
                foreach(var s in student)
                {
                    Console.WriteLine(s.Name);
                }
            }
            Console.WriteLine(groupedStudents.Count());

            /////////////////////////////////////////
            Console.WriteLine("\nWhere Statements\n");
            var students2 = studentList.Where(x => x.Department == "Biology").Select(x=>x);
            //var students2=from student in studentList where student.Id==1 select student;
            foreach(var student in students2)
            {
                Console.WriteLine(student.Id + " " + student.Name + " " + student.Age + " " + student.Department);
            }

            Console.WriteLine("**** LINQ Extension Methods *****");
            //var first=studentList.First(x => x.Name.StartsWith("N")).Name;
            //var firstOrDefault=studentList.FirstOrDefault(x=>x.Name.StartsWith("N")).Name;
            Console.WriteLine(studentList.Last(x=>x.Age==19).Name);
            Console.WriteLine(studentList.LastOrDefault(x=>x.Age>=20).Name);
            studentList.Remove(studentList.Last());
            Console.WriteLine(studentList.Last().Name);
            var stl= studentList.Take(3);
            foreach(Student student in stl)
            {
                Console.WriteLine(student.Id);
            }
            var stl2=studentList.TakeWhile(x => x.Age < 20);
            foreach(Student student in stl2)
            {
                Console.WriteLine(student.Age);
            }
            //studentList.Select(x => x.Name.Concat(" Little"));
            //foreach(Student student in studentList)
            //    Console.WriteLine(student.Name);

            Console.WriteLine("***********************");
            List<string> strings = new List<string>() { "a"};
            Console.WriteLine(strings.Last());
            Console.WriteLine(strings.LastOrDefault());

            List<string> strings2 = new List<string>() {  };
            //Console.WriteLine(strings2.Last());
            Console.WriteLine(strings2.LastOrDefault());

            Console.WriteLine("************");
            Console.ReadLine();
        }
    }
}
