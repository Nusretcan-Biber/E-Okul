using DataAccess.Abstract;
using DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Repository<T> : IRepository<T> where T : class
    {
        Context.Context c = new Context.Context();
        DbSet<T> _object;

        public Repository()
        {
            _object = c.Set<T>();
        }
        public int Delete(int id)
        {
            var model = _object.Find(id);
            _object.Remove(model);
            return c.SaveChanges();

        }

        public T GetById(int id)
        {
            return _object.Find(id);
        }

        public int Insert(T model)
        {
            _object.Add(model);
            return c.SaveChanges();
        }

        public List<T> GetAllList()
        {
            return _object.ToList();
        }

        public int Update(T model)
        {
            _object.Update(model);
            return c.SaveChanges();
        }
    }
}
