using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee_Management_System.AbstractClass;
using Employee_Management_System.Interfaces;

namespace Employee_Management_System.Models
{

    //Step 3: Employee Class
    public class Employee : Person, IWorker
    {
        public decimal Salary { get; set; }

        //Override Method Display() from Person Abstract class.
        public override void Display()
        {
            base.Display();

            Console.WriteLine($"Employee Salary is : {this.Salary}");
        }

        //Override method CalculateSalary() from Person Abstract class.
        public override decimal CalculateSalary()
        {
            return this.Salary;
        }

        //Must have implemented IWorker call DoWork() Interface method.
        public void DoWork()
        {
            Console.WriteLine($" Employee {this.Name} is Working and his Salary is {this.Salary}");
        }

    }
}
