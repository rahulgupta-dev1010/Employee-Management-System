using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_System.AbstractClass
{
    #region Abstract
    /*  1.An abstract class can have both implemented methods and abstract methods
        2.An abstract class can inherit from only one class.
        3.An abstract class cannot be instantiated directly
        3.An abstract class does not support multiple inheritance.
        4.When to use - use an abstract class when related classes share common state or implementation.
    */
    public abstract class Person
    {
        public int ID {get;set;}
        public string Name {get;set;}

        public virtual void Display()
        {
            Console.WriteLine($"Person ID : {this.ID} & and Person Name is : {this.Name}");
        }
        public abstract decimal CalculateSalary();
    }

    
    #endregion
}
