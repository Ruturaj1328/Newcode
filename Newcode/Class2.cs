using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Newcode.Employee;

namespace Newcode
{
    internal class Class2
    {
        static void Main(string[] args)
        {

            Manager m1 = new Manager("Kishor", 41000);
            m1.CalculateSalary();
            Console.WriteLine(m1);


            Employee e1 = new Employee("Tushar", 27000);
            e1.CalculateSalary();
            Console.WriteLine(e1);

        }
    }
}
