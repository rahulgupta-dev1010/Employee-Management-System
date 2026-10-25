using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_System.Func_Action_Predicate
{
    public class Func_Action_Predicate
    {
        public static void FuncActionPredicateDemo()
        {
            Console.WriteLine(
                "\n===== Func Action Predicate =====");

            Func<int, int, int> add =
                (a, b) => a + b;

            Console.WriteLine(
                add(10, 20));

            Action<string> print =
                x => Console.WriteLine(x);

            print("Hello Dot Net");

            Predicate<int> isEven =
                x => x % 2 == 0;

            Console.WriteLine(
                isEven(10));
        }
    }
}
