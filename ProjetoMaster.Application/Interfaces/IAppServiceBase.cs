using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMaster.Application.Interfaces
{
    public interface IAppServiceBase<T> where T : class
    {
        void Add(T obj);
        void Update(T obj);
        void Remove(T obj);
        T GetById(int id);
        IEnumerable<T> GetAll();
        void Dispose();
    }
}
