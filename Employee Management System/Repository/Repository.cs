using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_System.Repository
{
    //Repository (IRepository<T>) Implementation
    public class Repository<T> : IRepository<T>
    {
        private readonly List<T> listItem = new List<T>();

        public void Add(T item) { 
            listItem.Add(item);
        }

        public List<T> GetAll()
        {
            return listItem;
        }
    }
}
