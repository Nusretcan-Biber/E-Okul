using Data.Model;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class StudentRepository : Repository<Student>
    {

        // bu class bypass edilecek BaseService katmanından gelen işlem Respostory class'ına aktarılacak
        public int StudentDelete(int id) {

           return Delete(id); 
            
        }

        public Student StudentGetById(int id) {
            return GetById(id);
        }
        public int StudentInsert(Student model)
        {
            return Insert(model);

        }
        public int StudentUpdate(Student model)
        { 
            return Update(model);
        }
        // kaydettiyse 1 kaydetmediyse 0 hata oluştuysa -1

        public List<Student> GetAllStudentList()
        {
            return GetAllList();
        }


    }
}
