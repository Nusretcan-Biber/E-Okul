using Core.Check_List;
using Core.ExeptionControl;
using Data.Model;
using DataAccess;
using DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businnes.Base_Services
{
    public class BaseService<T> : IBaseService<T> where T : class
    {
        
       
        Exeptions exeption = new Exeptions();
        Repository<T> repository = new Repository<T>();
        Context c = new Context();
        DbSet<T> _object;


        public BaseService()
        {
            _object = c.Set<T>();
        }
        public string DeleteRequest(int Id)
        {
            if (repository.Delete(Id) != 0 )
            {
                return exeption.SuccessExeption();
            }
            else { return exeption.FailtureExeption() ; }

        }

        public List<T> GetAllListRequest()
        {
            var result = repository.GetAllList();
            if (result != null)
            {
                return result;
            }
            else { return null;  }
        }

        public T GetByIdRequest(int Id)
        {
            var result = repository.GetById(Id);
            if (result != null)
            {
                return result;
            }
            else { return null; }

        }

        public string InsertRequest(T model)
        {
            if (repository.Insert(model) != 0)
            {
                return exeption.SuccessExeption();
            }
            else { return exeption.FailtureExeption(); }
        }

        public string UpdateRequest(T model)
        {
            if (repository.Update(model) != 0)
            {
                return exeption.SuccessExeption();
            }
            else { return exeption.FailtureExeption(); }
        }
    }
}
