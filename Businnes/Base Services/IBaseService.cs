using Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businnes.Base_Services
{
    internal interface IBaseService<T>
    {
        string DeleteRequest(int Id);

        string InsertRequest(T model);

        string UpdateRequest(T model);

        List<T> GetAllListRequest();

        T GetByIdRequest(int Id);
    }
}
