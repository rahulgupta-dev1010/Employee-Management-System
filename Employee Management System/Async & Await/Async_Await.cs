using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_System.Async___Await
{
    public class Async_Await
    {
        public static async Task AsyncDemo()
        {
            Console.WriteLine(
                        "\n===== Async Await =====");

            await Task.Delay(5000); //hold this until the current proceess is not completed.

            Console.WriteLine("Task Completed");
        }
    }
}
