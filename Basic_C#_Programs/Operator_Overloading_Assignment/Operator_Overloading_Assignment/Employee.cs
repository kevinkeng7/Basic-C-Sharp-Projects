using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overloading_Assignment
{
    public class Employee
    {
        public static bool operator ==(Employee a, Employee b)
        {
            return Equals(a.Id, b.Id); //Id
        }

        public static bool operator !=(Employee a, Employee b)
        {
            return !Equals(a.Id, b.Id);
        }

        public int Id { get; set; }
    }
}
