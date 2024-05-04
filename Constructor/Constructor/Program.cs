using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
   

    internal class Program
    {
        public class Employee
        {
            private string firstName;
            private string lastName;
            private double salary;

            public string FirstName
            {
                get { return firstName; }
                set { firstName = value; }
            }

            public string LastName
            {
                get { return lastName; }
                set { lastName = value; }
            }

            public double Salary
            {
                get { return salary; }
                set { salary = value; }
            }

            public Employee(string firstName, string lastName, double salary)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.salary = salary;
            }

            public void ShowFullName()
            {
                Console.WriteLine($"Full Name: {firstName} {lastName}");
            }

            public void IncrementSalary(double s)
            {
                salary += s;
            }
        }
        static void Main(string[] args)
        {
            Employee emp = new Employee("Ram", "Bahadur", 20000);
            emp.ShowFullName();
            Console.WriteLine($"Salary: {emp.Salary}");
            emp.FirstName = "Hari";
            emp.IncrementSalary(5000);
            emp.ShowFullName();
            Console.WriteLine($"Salary: {emp.Salary}");
            Console.ReadKey();
        }
    }
}
