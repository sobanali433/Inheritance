
//using Microsoft.VisualBasic;
//using System;
//using System.Diagnostics;
//using System.Security.Cryptography.X509Certificates;

using System.Collections.Concurrent;
using System.ComponentModel.Design;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Threading.Channels;
using System.Transactions;
using System.Xml.Linq;






//1121



//using System.Threading.Channels;

//public class Vehicle
//{
//    public string Brand { get; set; }
//    public int Speed { get; set; }
//    public void Start()
//    {
//        Console.WriteLine("Vehicle is Start");
//    }
//}
//public class Car : Vehicle
//{
//    public int Door { get; set; }
//    public void CarDoor()
//    {
//        Console.WriteLine($"Car have {Door} doors");
//    }

//}
//public class Bike : Vehicle
//{
//    public bool hasHelment { get; set; }
//    public void HasHelemt()
//    {
//        Console.WriteLine("Bike Rider have helment");
//    }

//    public class Program
//    {
//        public static void Main()
//        {
//            Car car = new Car();
//            car.Start();
//            car.Brand = "Toyota";
//            car.Speed = 120;
//            car.Door = 4;
//            car.CarDoor();



//            Console.WriteLine(car.Brand);
//            Bike bike = new Bike();
//            bike.Brand = "Honda";
//            bike.Speed = 80;
//            bike.hasHelment = true;
//            bike.Start();
//            bike.HasHelemt();
//        }
//    }
//}



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


//public class EMPLOYEE
//{
//    public string Name { get; set; }
//    public decimal BaseSalary { get; set; }

//    public void yourName()
//    {
//        Console.WriteLine("Employee Name: " + Name);
//    }
//    public void EmployeeDetails()
//    {
//        Console.WriteLine("Employee Base Salary: " + BaseSalary);
//    }
//}

//public class DEVELOPER : EMPLOYEE
//{
//    public void DeveloperDetails()
//    {
//        Console.WriteLine("Developer Base Salary: " + BaseSalary);
//    }
//}

//public class SALES : EMPLOYEE
//{
//    public void SalesDetails()
//    {
//       Console.WriteLine("Salse Base Salary: " + BaseSalary);
//    }
//}

//public class Program
//{
//    public static void Main()
//    {
//        EMPLOYEE employee = new EMPLOYEE();
//        employee.Name = "SOBAN";
//        employee.BaseSalary = 1000m;
//        employee.EmployeeDetails();
//        employee.yourName();

//        Console.WriteLine();

//        DEVELOPER developer = new DEVELOPER();
//        developer.Name = "Ali";
//        developer.BaseSalary = 2000.00m;
//        developer.DeveloperDetails();
//        developer.yourName();


//        Console.WriteLine();

//        SALES sales = new SALES();
//        sales.Name = "Ahmed";
//        sales.BaseSalary = 3000.00m;
//        sales.SalesDetails();
//        developer.yourName();



//    }
//}


//public class Dev
//{
//    public string Name { get; set; }
//    public string DEVNAME() 
//    {
//        Console.WriteLine("THIS IS DEV");
//        return Name;
//    }
//}
//public class Hr : Dev
//{
//    public  string policy { get; set; }
//    public  decimal salary { get; set; }


//    public void HrRules()
//    {
//        Console.WriteLine("THIS IS HR POLICY");
//        Console.WriteLine("THIS IS SALARY");
//    }

//}
//public class Program
//{
//    public static void Main()
//    {
//Dev dev = new Dev();
//dev.Name = " SOBAN";
//dev.DEVNAME();

//Hr hr = new Hr();
//hr.Name = "Ali";
//hr.policy = "TODAY OFF";
//hr.salary = 2000.000m;

//Console.WriteLine(hr.Name);
//Console.WriteLine(dev.Name);
//hr.HrRules();
//hr.DEVNAME();
//}
//}