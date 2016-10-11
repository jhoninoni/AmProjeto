using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoMaster.Domain.Interfaces.Services;
using ProjetoMaster.Domain.Interfaces.Services;

namespace ProjetoMaster.Domain.Services
{
    public class ServiceBase<T> : IServiceBase<T> where T : class
    {
        protected readonly IRepositoryBase<T> _repositoryBase;

        public ServiceBase(IRepositoryBase<T> repositoryBase)
        {
            _repositoryBase = repositoryBase;
        }

        public void Add(T obj)
        {
            _repositoryBase.Add(obj);
        }

        public void Update(T obj)
        {
            _repositoryBase.Update(obj);
        }

        public void Remove(T obj)
        {
            _repositoryBase.Remove(obj);
        }

        public T GetById(int id)
        {
            return _repositoryBase.GetById(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _repositoryBase.GetAll();
        }

        public void Dispose()
        {
            _repositoryBase.Dispose();
        }
    }
}
