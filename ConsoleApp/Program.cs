
//using Microsoft.VisualBasic;
//using System;
//using System.Diagnostics;
//using System.Security.Cryptography.X509Certificates;




////public class Program
////{
////    public decimal Balance { get; set; }
////    public void GetBalance(decimal amount)
////    {
////        Balance += amount;
////    }
////    public void WithDraw(int withraw)
////    {
////        if (Balance < 0) 
////        {
////            Console.WriteLine("-ve amount ");
////        }
////        if (withraw > Balance)
////            {
////                Console.WriteLine("Insufficient balance");
////            }
////            else
////            {
////                Balance -= withraw;
////                Console.WriteLine($"Your current balance is {Balance}");
////        }
////    }
////public static void Main()
////{
////    Program program = new Program();
////    program.GetBalance(3900.00m);
////    program.WithDraw(1000);
////}
////}


//public class Program
//{
//    public static void Main()
//    {
//        int number1 = int.Parse(Console.ReadLine());
//        int number2 = int.Parse(Console.ReadLine());
//        //int number3 = int.Parse(Console.ReadLine());
//        //int number4 = int.Parse(Console.ReadLine());
//        //int number5 = int.Parse(Console.ReadLine());

//        for (int n =5; n < number1; n++)
//        {
//            Console.WriteLine(n+ "greater");

//            for (int m = 10; m < number2; m++)
//            {
//                Console.WriteLine(m + "2nd greater");
//            }
//        }
//    }

//}








//        //int a = number;
//        //string message;
//        //message = (number > 18) ? "You are an adult" : "You are a minor";

//        //for (int i=0; i <= 5; i++)
//        //{
//        //    for (int j =0; j <= i; j++)
//        //    {
//        //        Console.Write("LOVE");
//        //    }
//        //    Console.WriteLine();        
//        //}












//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _11_SimpleClasses
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Car myCar = new Car();
//            myCar.Make = "Oldsmobile";
//            myCar.Model = "Cutlas supreme";
//            myCar.Year = 1986;
//            myCar.color = "Silver";

//            Console.WriteLine("{0} {1} {2} {3}", myCar.Make, myCar.Model, myCar.Year, myCar.color);

//            decimal value = DetermineMarketValue(myCar);
//            //Console.WriteLine("{0:C}", value);

//            Console.WriteLine("{0:C}", myCar.DetermineMarketValue());

//            Console.ReadLine();
//        }

//        private static decimal DetermineMarketValue(Car car)
//        {
//            decimal carValue = 100.0M;
//            return carValue;
//        }
//        class Car
//        {
//            public string Make { get; set; }
//            public string Model { get; set; }
//            public int Year { get; set; }
//            public string color { get; set; }

//            public decimal DetermineMarketValue()
//            {
//                decimal carValue;

//                if (Year > 1990)
//                {
//                    carValue = 10000;
//                }
//                else
//                    carValue = 2000;

//                return carValue;
//            }
//        }
//    }
//}







using System;
using System.Reflection.Metadata;

class person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public person(string n, int a)
    {
        Name = n;
        Age = a;
    }

    public void PersonDisplay()
    {
        Console.WriteLine($"Name: {Name} Age: {Age}");
    }

    class Employee : person
    {
        public string Company { get; set; }
        public string Posistion { get; set; }
        public decimal Salary { get; set; }
        public Employee(string n, int a, string c, string p, decimal s): base(n, a)
        {
            Posistion = p;
            Company = c;
            Salary = s;
        }

        public void EmployeeDeisplay()
        {
            Console.WriteLine($"Company: {Company} Position: {Posistion} Salary: {Salary}");
        }

    }
    public static void Main()
    {

        Console.WriteLine("Enter the NAME");
        string Name  = Console.ReadLine();

        Console.WriteLine("Enter your AGE");
        int Age   = Convert.ToInt32(Console.ReadLine());


            person p = new person(Name, Age);
            p.PersonDisplay();
        

        Employee employee = new Employee(Name, Age, "Microsoft", "Software Engineer", 100000);
        employee.EmployeeDeisplay();

        Console.ReadLine();





    }
}