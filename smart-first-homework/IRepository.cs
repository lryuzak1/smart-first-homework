using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smart_first_homework
{
    public interface IRepository<T> where T:class
    {
        void Delete(int id);
        T GetByID(int id);
        IEnumerable<T> GetAll();
    }
}
