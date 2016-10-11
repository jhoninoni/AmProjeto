using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoMaster.Domain.Interfaces.Services;
using ProjetoMaster.Infra.Data.Contexto;

namespace ProjetoMaster.Infra.Data.Repositories
{
    public class RepositoryBase<T> : IDisposable, IRepositoryBase<T> where T : class
    {
        protected readonly ContextDb Db;

        public RepositoryBase()
        {
            Db = new ContextDb();
        }

        public void Add(T obj)
        {
            Db.Set<T>().Add(obj);
            Db.SaveChanges();
        }

        public void Update(T obj)
        {
            Db.Entry(obj).State = EntityState.Modified;
            Db.SaveChanges();
        }

        public void Remove(T obj)
        {
            Db.Set<T>().Remove(obj);
            Db.SaveChanges();
        }

        public T GetById(int id)
        {
            return Db.Set<T>().Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return Db.Set<T>().ToList();
        }

        public void Dispose()
        {
            Db.Dispose();
        }
    }
}
