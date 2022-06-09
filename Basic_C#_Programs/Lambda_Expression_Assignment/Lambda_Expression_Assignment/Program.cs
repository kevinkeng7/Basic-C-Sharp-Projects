using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expression_Assignment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Employee> employeeList = new List<Employee>()
            {
                new Employee { FirstName = "Joe", LastName = "Forte", Id = 9 }, //At least two employees should have the first name "Joe".
                new Employee { FirstName = "Joe", LastName = "Piano", Id = 6 }, //At least two employees should have the first name "Joe".
                new Employee { FirstName = "Uncle", LastName = "Sam", Id = 1 },
                new Employee { FirstName = "Fanny", LastName = "May", Id = 3 },
                new Employee { FirstName = "Freddy", LastName = "Mac", Id = 4 },
                new Employee { FirstName = "Jerry", LastName = "Springer", Id = 5 },
                new Employee { FirstName = "Helly", LastName = "Henson", Id = 2 },
                new Employee { FirstName = "Fall", LastName = "Winter", Id = 10 },
                new Employee { FirstName = "Road", LastName = "Rage", Id = 8 }, //Each employee should have a first and last name, as well as an Id
                new Employee { FirstName = "Chess", LastName = "Board", Id = 7 } //create a list of at least 10 employees
            };

            List<Employee> employeeListJoe = new List<Employee>();

            int counter = 0;
            foreach (Employee employee in employeeList) //Using a foreach loop, create a new list of all employees with the first name "Joe".
            {
                if (employee.FirstName == "Joe")
                {
                    employeeListJoe.Add(employee);
                    counter++;
                }
            }

            //List<Employee> employeeListJoe = employeeList.Where(x => x.FirstName == "Joe").ToList();     //create a new list of all employees with the first name "Joe". but this time with a lambda expression.

            //List<Employee> employeeListJoe = employeeList.Where(x => x.Id > 5).ToList();     //Using a lambda expression, make a list of all employees with an Id number greater than 5.

            foreach (Employee employee in employeeListJoe) 
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName} {employee.Id}");
            }
            Console.ReadLine();
        }
    }
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
    }    
}
