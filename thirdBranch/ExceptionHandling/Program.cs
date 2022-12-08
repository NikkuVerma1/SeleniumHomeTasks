using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Department { get; set; }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            ///////////// Multiple catch block
            
            int a = 10, b=0;
            int c = 0;
            int[] arr = { 1, 2, 3 };

            List<Student> studentList = new List<Student>();
            studentList.Add(new Student { Id = 101, Name = "John", Age = 18, Department = "Marketing" });
            studentList.Add(new Student { Id = 202, Name = "Lily", Age = 28, Department = "Finance" });
            studentList.Add(new Student { Id = 303, Name = "Jenny", Age = 23, Department = "Analytics" });
            studentList.Add(new Student { Id = 308, Name = "Stuart", Age = 19, Department = "E&C" });
            studentList.Add(new Student { Id = 404, Name = "George", Age = 17, Department = "IT" });


            try
            {
                c = a / b;
                Console.WriteLine("Divide by zero operation inside try block");
            }catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }catch(ArithmeticException e)
            {
                Console.WriteLine(e.Message);
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Finally block executed");
            }

            //////////////////// Custom Exception Example
            
            Student student = new Student();
            student.Id = 101;
            student.Name = "Arun12";
            try
            {
                if (student.Name.EndsWith("12"))
                    throw new InvalidNameException(student.Name);

            }catch(InvalidNameException e)
            {
                Console.Write(" is an invalid name");
            }

            //////////////////
            foreach(Student stu in studentList)
            {
                try
                {
                    if(stu.Age<18)
                        throw new InvalidAgeException();
                    Console.WriteLine(stu.Id + " " + stu.Name + " " + stu.Age + " " + stu.Department);
                }catch(InvalidAgeException e)
                {
                    Console.WriteLine(e.Message);
                }
            }


            //////////// only try-finally
            
            //try
            //{
            //    int i= arr[3];
            //}
            //finally
            //{
            //    Console.WriteLine("\nFinally block");
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            Console.ReadLine();
        }
    }
}
