using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IRepository<T>
    {
        int Insert(T model);
        int Update(T model);
        int Delete(int id);
        List<T> GetAllList();
        T GetById(int id);

    }
}
