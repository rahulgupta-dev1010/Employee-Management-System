using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_System.Models
{
    //Step 4: Manager Class
    public class Manager : Employee
    {
        public decimal Bonus {  get; set; }

        public override decimal CalculateSalary()
        {
            return this.Salary + this.Bonus;
        }
    }
}
