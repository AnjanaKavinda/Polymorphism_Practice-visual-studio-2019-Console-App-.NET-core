using System;

namespace Polymorphism_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] em = new Employee[4];
            em[0] = new Employee();
            em[1] = new FullTimeEmployee();
            em[2] = new PartTimeEmployee();
            em[3] = new TempporaryEmployee();

            foreach (Employee employee in em)
            {
                employee.PrintFullName();
            }
        }
    }
    public class Employee
    {
        public string FirstName = "Fn";
        public string LastName = "Ln";

        public virtual void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }

    public class FullTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName + "- Full Time");
        }
    }
    public class PartTimeEmployee :Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName + "- Part Time");
        }
    }
    public class TempporaryEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName + "- Tempporary");
        }
    }
}
