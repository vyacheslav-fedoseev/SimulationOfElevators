using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Repositories
{
    public interface IRepository<out T> where T: class
    {
        T Find(int id);
        IEnumerable<T> GetAll();
    }
}
