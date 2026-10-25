using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_System.Delegates
{
    //Step 6: Delegate
    public class SalaryDelegate
    {
        public delegate decimal BonusCalculator(
            decimal salary     
        );

        public static void DelegateDemo()
        {
            Console.WriteLine(
                "\n===== Delegate =====");

            BonusCalculator calc =
                CalculateBonus;

            decimal bonus =
                calc(50000);

            Console.WriteLine(
                $"Bonus = {bonus}");
        }

        public static decimal CalculateBonus(
            decimal salary)
        {
            return salary * 0.10M;
        }

    }
}
