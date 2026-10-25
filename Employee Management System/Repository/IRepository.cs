using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_System.Repository
{
    //Step 5: Generic Repository
    public interface IRepository<T>
    {
        void Add(T item);
        List<T> GetAll();
    }
}
