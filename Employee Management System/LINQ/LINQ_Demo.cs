using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee_Management_System.Models;

namespace Employee_Management_System.LINQ
{
    public class LINQ_Demo
    {
        private string LINQs = "========Doing Operation in Language Integrated Query=========";

        public static void LINQDemo(List<Employee> empList)
        {
            //LINQs = "Encapsulated '" + LINQs + "'"; //Hiding Initial data and showing only initial data.(Encapsulation Approach)
            Console.WriteLine("------- LINQ --------");
            var highestEmployeeSalary = empList
                                        .Where(x => x.Salary > 60000)
                                        .OrderByDescending(x => x.Salary);

            foreach(Employee item in highestEmployeeSalary)
            {
                Console.WriteLine($"Employee Name : {item.Name} --- Salary : {item.Salary}");
            }
        }

        #region Additional LINQ Practice

        //1. Group By
        public static void GroupBYCase(List<Employee> employees)
        {
            var group = employees
                        .GroupBy(tmp => tmp.Salary);
            
            try
            {
                foreach (IGrouping<decimal,Employee> item in group)
                {
                    Console.WriteLine($"Group By Filter : Employee Salary : {item.Key}");
                    foreach (Employee emp in item)
                    {
                        Console.WriteLine($"Employee Name : {emp.Name}");
                    }
                }
            }catch(System.InvalidCastException ex) { Console.WriteLine($"Something was missing for exception : {ex.Message}"); }
            
        }

        //2. Average Salary
        public static void AverageSalaryCase(List<Employee> employees) {
            var averageSalary = employees
                                .Average(x => x.Salary);
            Console.WriteLine($"Employee Average Salary : {averageSalary}");
        }

        //3. Highest Salary
        public static void HighestSalary(List<Employee> employees)
        {
            Console.WriteLine($"Employee Highest Salary : {employees.Max(tmp => tmp.Salary)}");

        }


        #endregion

    }
}
