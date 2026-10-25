using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Employee_Management_System.Models;

namespace Employee_Management_System.Stack
{
    public static class Stack_Operation
    {
        //creating a new stack object which will store list employee object.
       static Stack<Employee> listOfStackEmpRecord = new Stack<Employee>();

        //creating method to get all list of employee and then add into the stack object record.
        public static void StackDemos(List<Employee> employees)
        {
            foreach (Employee emp in employees)
            {
                listOfStackEmpRecord.Push(emp);
            }

            Console.WriteLine();
            Console.WriteLine("========List of Stack Employee Record==========");
            Console.WriteLine();

            foreach (Employee empRec in listOfStackEmpRecord)
            {
                Console.WriteLine($"Stack Employee Record : ID -- {empRec.ID} == Name -- {empRec.Name} == Salary -- {empRec.Salary}");
            }
        }
    }
}
