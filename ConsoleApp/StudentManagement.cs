using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public class StudentManagement
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }


        public void StudentDetails()
        {
            List<Student> Students = new List<Student>();

            while (true)
            {

                Console.WriteLine("Enter what you want");
                Console.WriteLine("Add Student " + 1);
                Console.WriteLine("View Student " + 2);
                Console.WriteLine("Update Student " + 3);
                Console.WriteLine("Delete Student " + 4);

                int input = int.Parse(Console.ReadLine());
                if (input == 1)
                {
                    Student student = new Student();
                    Console.WriteLine("Enter Id : ");
                    int Ids = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter Name : ");
                    string Names = Console.ReadLine();

                    Console.WriteLine("Enter Age : ");
                    int Ages = int.Parse(Console.ReadLine());

                    student.Id = Ids;
                    student.Name = Names;
                    student.Age = Ages;

                    Students.Add(student);
                    Console.WriteLine("STUDENT ADD SUCCSECCFULLY!");

                }
                if (input == 2)
                {

                    Console.WriteLine("VIEW STUDENT");
                    Console.WriteLine("Enter Id : ");
                    int Ids = int.Parse(Console.ReadLine());
                    foreach (var student in Students)
                    {
                        if (Ids == student.Id)
                        {
                            Console.WriteLine("Id : " + student.Id);
                            Console.WriteLine("Name : " + student.Name);
                            Console.WriteLine("Age : " + student.Age);
                        }

                    }

                }
                if (input == 3)
                {

                }
                else { Console.WriteLine("Invalid Record"); }
            }

        }
    }

    public class program
    {
        public static void Main(string[] args)
        {
            StudentManagement student = new StudentManagement();
            student.StudentDetails();
        }

    }
}
