using OOPSPROJECT_TQ;
using OOPSPROJECT_TQ.AbstractProgram;
using OOPSPROJECT_TQ.Arrays;
using OOPSPROJECT_TQ.Delegates;
using OOPSPROJECT_TQ.ExceptionHandling;
using OOPSPROJECT_TQ.Inheritance;
using OpenXmlPowerTools;
using System.Runtime.InteropServices;
using static OOPSPROJECT_TQ.Delegates.SingleDelegates;
using static OOPSPROJECT_TQ.Delegates.User2;
using static OOPSPROJECT_TQ.ExceptionHandling.CustomExceptionName;
using static OOPSPROJECT_TQ.ExceptionHandling.CustomExceptions;
using Enum = System.Enum;

namespace OOPSPROJECT_TQ
{
    public class Program
    {
        static void Main(string[] args)
        {







            //Date dateObj1 = new Date();
            //dateObj1.AcceptDate(4, "Aug", 2023);
            //string res = dateObj1.PrintDate();
            //Console.WriteLine( res)

            /*GetSetStudent StudentObj1 = new GetSetStudent();
            StudentObj1.AcceptData(08,80,"Ali","CSE");
            string res = StudentObj1.PrintData();
            Console.WriteLine(res);


            EmployeeSalary EmployeeObj1 = new EmployeeSalary();
            EmployeeObj1.AcceptData(40, 80000, "Ali", "IT");
            string res1 = EmployeeObj1.PrintData();
            Console.WriteLine(res1);

            Book BookObj1 = new Book();
            BookObj1.AcceptData(1448, 800, "Sub'tle art of not giving a f*ck", "Mark Manson");
            string res2 = BookObj1.PrintData();
            Console.WriteLine(res2);

            StudentMarks StudentMarksObj1 = new StudentMarks();
            StudentMarksObj1.AcceptData("Ali", 80, 40, 24);
            StudentMarksObj1.CalculatePer();
            string Per = StudentMarksObj1.PrintData();
            Console.WriteLine(Per);


            EmployeeSal emp=new EmployeeSal();
            EmployeeSal emp1 = new EmployeeSal(1,"Ali",80000);
            Console.WriteLine(emp1);  

            Student2 stud = new Student2();
            stud.RollNo = 1;
            stud.Name = "Ali";
            stud.Percentage = 88.40;
            Console.WriteLine($"{stud.RollNo} {stud.Name} {stud.Percentage}");
            Console.WriteLine(stud.Print());

            Student2 stud2 = new Student2() { RollNo = 2, Name = "Amay", Percentage = 88.00 };
            Console.WriteLine($"{stud2.RollNo} {stud2.Name} {stud2.Percentage}");



            ProductGetSet p = new ProductGetSet();
            p.Id = 1;
            p.Name = "Laptop";
            p.Price = 88000;
            Console.WriteLine($"{p.Id} {p.Name} {p.Price}");
            Console.WriteLine(p.Print());

            ProductGetSet p2 = new ProductGetSet() { Id = 2, Name = "Tablet", Price = 40000 };
            Console.WriteLine($"{p2.Id} {p2.Name} {p2.Price}");



            Movie m1 = new Movie(4,"Fight Club",400,15);
            Console.WriteLine("Enter the no. of ticket you want to book");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(m1.BookTicket(num));
            Console.WriteLine("Enter type for ticket 1.Silver 2.Gold 3.Platinum");
            int choice=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(m1.Findcost(choice));


            */
            /*MethodOverloading m = new MethodOverloading();
            Console.WriteLine(m.Addition(10, 20, 30));
            Console.WriteLine(m.Addition(40, 20, 80));
            */


            /*Car c = new Car("hyundia","i10",800000);


            Console.WriteLine(c.Accept);
            */

            /* Rectangle r = new Rectangle(4,4);
             Console.WriteLine(r.Display());
             r.Area();
             Console.WriteLine(r.Draw("It is a Rectangle"));
             Console.WriteLine(r.Print("It is a Cicle"));

            IphonePro p = new IphonePro();
            // p.displayPhone();
            p.show();
            //  p.Price();*/

            /* MethodOverloadingMethodOverriding m = new MethodOverloadingMethodOverriding();
             Console.WriteLine(m.Addition(4, 4));
             Console.WriteLine(m.Addition(4,8,4));
             Console.WriteLine(m.Addition(4,848));
             Console.WriteLine(m.Addition(9,8.4));
             Console.WriteLine(m.Addition(9.5, 8.4));


             ChildClass c = new ChildClass();
             Console.WriteLine(c.Add(8,12));

             Parent p = new Parent();
             p.Show();
             p.Hide();

            */

            /*Dog d= new Dog();
            d.showColor();

            Dog1 d2 = new Dog1();
            d2.eat();*/


            /*int[]arr1 = new int[5];
            Console.WriteLine(AverageofArray.Average(arr1));
            double[]arr2 = new double[5];
            Console.WriteLine(AverageofArray.Average(arr2));*/



            Product[] list = new Product[3];
            list[0] = new Product();
            list[0].Id = 1;
            list[0].Name = "Test";
            list[0].Price = 100;
            list[1] = new Product();
            list[1].Id = 2; list[1].Name = "Test2";
            list[1].Price = 500;


            /* {
                 new Product { Id = 1, Name = "Mouse", Price = 499 };
                 new Product { Id = 2, Name = "Pen", Price = 20 };
                 new Product { Id = 3, Name = "Pencil", Price = 10 };
             };*/
            /* foreach (Product p in list)
             {
                 if (p != null)
                 {
                     Console.WriteLine($"{p.Id},{p.Name},{p.Price}");
                 }
             }*/

            /*Struct s = new Struct(10,40);
            Console.WriteLine(s.Print());
            */

            /*
                        ToStringMethod s = new ToStringMethod(1,"Pen",10);
                        Console.WriteLine(s.ToString());
            */


            /* Product p1 = new Product();
             {
                 p1.Id = 3;
                 p1.Name = "Pen";
                 p1.Price = 5;
             };
             Console.WriteLine(p1.ToString());
            */


            /* try
             {
                 User user1 = new User(17);
             }
             catch (AgeException ex)
             {
                 Console.WriteLine(ex.Message);
             }
            */
            /* try
             {
                 try
                 {
                     CustomExceptionName n = new CustomExceptionName();
                 }
                 catch (NameException ex)
                 {
                     Console.WriteLine(ex.Message);
                 }
             }
             finally
             {
                 Console.WriteLine("Name is required");
             }
            */


            /* Calculation c1 = new Calculation();
             MyDelegate myDelegate = new MyDelegate(c1.Addition); // assign the method reference

             // invoke the method using delegate
             int result = myDelegate.Invoke(45, 67);
             Console.WriteLine(result);
            }*/

            //User2 u = new User2();
            //MyDelegate1 md = new MyDelegate1(User2.UpperCase);
           // Console.WriteLine();
           
          
         


        }
    }
}























