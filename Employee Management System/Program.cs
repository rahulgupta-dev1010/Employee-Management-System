using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee_Management_System.Repository;
using Employee_Management_System.Models;
using Employee_Management_System.LINQ;
using Employee_Management_System.Delegates;
using Employee_Management_System.Func_Action_Predicate;
using Employee_Management_System.Async___Await;
using Employee_Management_System.Dictionary;
using Employee_Management_System.Queue;
using Employee_Management_System.Stack;

namespace Employee_Management_System
{
    public static class Program
    {
        #region Add Employee
        public static void AddEmployee(Repository<Employee> repository)
        {
            repository.Add(
                new Employee
                {
                    ID = 1,
                    Name = "Rahul Gupta",
                    Salary = 55000
                });

            repository.Add(
                new Employee
                {
                    ID = 2,
                    Name = "Rohit Yadav",
                    Salary = 72000
                });

            repository.Add(
                new Employee
                {
                    ID = 3,
                    Name = "Priya Singh",
                    Salary = 65000
                });
        }

        #endregion
        static async Task Main()
        {
           Repository<Employee> repository = new Repository<Employee>();


            #region Employee Information

            //Adding Employee in Repo list.
            Program.AddEmployee(repository);

            Console.WriteLine(
           "===== Employee List =====");
            foreach (Employee employee in repository.GetAll())
            {
                employee.Display();
                employee.DoWork();

                Console.WriteLine();
            }

            #endregion


            #region LINQ
            // Invoking LinQ Approach from LINQ_Demo class that provides salary list when salary > 60000

            LINQ_Demo.LINQDemo(repository.GetAll());

            LINQ_Demo.GroupBYCase(repository.GetAll());
            LINQ_Demo.AverageSalaryCase(repository.GetAll());
            LINQ_Demo.HighestSalary(repository.GetAll());

            #endregion


            #region Delegate
            SalaryDelegate.DelegateDemo();
            #endregion


            #region FUNC ACTION PREDICATE
            //===== Func Action Predicate =====//

            Func_Action_Predicate.Func_Action_Predicate.FuncActionPredicateDemo();

            #endregion


            #region Async & Await

            await Async___Await.Async_Await.AsyncDemo();

            #endregion


            #region Dictionary

            Dictionary.DictionaryDemo.AddDictionaryDemo(repository.GetAll());

            #endregion


            #region Queue

            Queue.Queue.QueueDemo(repository.GetAll());

            #endregion


            #region Stack

            Stack_Operation.StackDemos(repository.GetAll());

            #endregion

        }
    }
}
