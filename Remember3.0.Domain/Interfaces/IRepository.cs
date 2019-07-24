using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remember3._0.Domain.Interfaces
{
    public interface IRepository<T> where T: class
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        void Delete(int id);
        void Create(T Entity);
        void Edit(T Entity);
    }
}
