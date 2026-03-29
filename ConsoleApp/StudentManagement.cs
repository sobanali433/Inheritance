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
            List<StudentManagement> Students = new List<StudentManagement>();

            while (true)
            {

                Console.WriteLine("Enter what you want");
                Console.WriteLine("Add Student " + 1);
                Console.WriteLine("View Student " + 2);
                Console.WriteLine("Update Student " + 3);
                Console.WriteLine("Delete Student " + 4);
                Console.WriteLine("Delete Student " + 5);

                int input = int.Parse(Console.ReadLine());
                if (input == 1)
                {
                    StudentManagement student = new StudentManagement();
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
                if (input == 4)
                {
                    Console.WriteLine("Enter Id : ");
                    int Ids = int.Parse(Console.ReadLine());

                    foreach (var student in Students)
                    {
                        if (Ids == student.Id)
                        {
                            Students.Remove(student);
                            Console.WriteLine("STUDENT DELETE SUCCSECCFULLY!");
                        }
                        else { Console.WriteLine("NOT FOUND User"); }
                    
                    }

                }
                if (input == 5)
                {
                    Console.WriteLine("Exiting Program...");
                    break;
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
