using Employee_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_System.Queue
{
    public static class Queue
    {
       public static Queue<Employee> listOfQueueEmployee = new Queue<Employee>();

        public static void QueueDemo(List<Employee> emp)
        {
            foreach (Employee item in emp)
            {
                listOfQueueEmployee.Enqueue(item);
            }

            Console.WriteLine();
            Console.WriteLine("========List of Queue Employee Record==========");
            Console.WriteLine();

            foreach (Employee item in listOfQueueEmployee)
            {
                Console.WriteLine($"Queue Record : ID - {item.ID}, -- Name - {item.Name}, -- Salary - {item.Salary}");    
            }

        }
    }
}
