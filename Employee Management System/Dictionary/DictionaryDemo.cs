using Employee_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_System.Dictionary
{
    public static class DictionaryDemo
    {

        public static void AddDictionaryDemo(List<Employee> employees)
        {
            Dictionary<int, string> pairs = new Dictionary<int, string>();

            //Creating new dicitionary list object to store a list of arguement employees.
            foreach (Employee item in employees)
            {
                pairs.Add(item.ID, item.Name);
            }

            //Now display the list of dictionary records.
            Console.WriteLine("=======  Dictionary Records =========");
            Console.WriteLine();
            foreach (var valuePairs in pairs)
            {
                Console.WriteLine($"Dictionary Records key : {valuePairs.Key} and there value : {valuePairs.Value}");
            }

        }
    }
}
