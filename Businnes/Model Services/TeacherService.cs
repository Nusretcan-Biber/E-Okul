using Businnes.Base_Services;
using Core.Check_List;
using Core.ExeptionControl;
using Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businnes.Model_Services
{
    public class TeacherService : BaseService<Teacher>
    {
        Queries<Teacher> queries = new Queries<Teacher>();

        Exeptions exeption = new Exeptions();
        public string TeacherDeleteRequest(int id)
        {
            if (Extensions.CheckNumberIsNull(id))
            {
                return exeption.NullExeption();
            }
            else if (queries.CheckIsNumberNegative(id))
            {
                return exeption.NegativeExeption();
            }
            else if (!queries.CheckIsExistId(id))
            {
                return exeption.IsNotExistIdExeption();
            }
            else
            {
                if (DeleteRequest(id) == exeption.SuccessExeption())
                {
                    return exeption.SuccessExeption();
                }
                else
                {
                    return exeption.FailtureExeption();
                }
            }
        }

        public List<Teacher> TeacherGetAllRequest()
        {
            return GetAllListRequest();
        }
        public Teacher TeacherGetByIdRequest(int id)
        {
            return GetByIdRequest(id);
        }

        public string TeacherInsertRequest(Teacher model)
        {
            if (Extensions.CheckNumberIsNull(model.teacherId))
            {
                return exeption.NullExeption();
            }
            else if (queries.CheckIsNumberNegative(model.teacherId))
            {
                return exeption.NegativeExeption();
            }
            else if (queries.CheckIsExistId(model.teacherId))
            {
                return exeption.IsExistNumberExeption();
            }
            else if (queries.CheckTextIsNull(model.teacherName))
            {
                return exeption.NullExeption();
            }
            else if (queries.CheckStringsAreInteger(model.teacherName))
            {
                return exeption.NumberExeption();
            }
            else if (queries.CheckLenghtOfStrings(model.teacherName))
            {
                return exeption.LenghtExeption();
            }
            else if (queries.CheckTextIsNull(model.teacherSurname))
            {
                return exeption.NullExeption();
            }
            else if (queries.CheckStringsAreInteger(model.teacherSurname))
            {
                return exeption.NumberExeption();
            }
            else if (queries.CheckLenghtOfStrings(model.teacherSurname))
            {
                return exeption.LenghtExeption();
            }
            else if (queries.CheckTextIsNull(model.teacherPassword))
            {
                return exeption.NullExeption();
            }
            else if (queries.CheckLenghtOfStrings(model.teacherPassword))
            {
                return exeption.LenghtExeption();
            }
            else if (queries.CheckTextIsNull(model.teacherEmail))
            {
                return exeption.NullExeption();
            }
            else
            {
                if (InsertRequest(model) == exeption.SuccessExeption())
                {
                    return exeption.SuccessExeption();
                }
                else
                {
                    return exeption.FailtureExeption();
                }
            }

        }

        public string TeacherUpdateRequest(Teacher model)
        {
            if (Extensions.CheckNumberIsNull(model.teacherId))
            {
                return exeption.NullExeption();
            }
            else if (queries.CheckIsNumberNegative(model.teacherId))
            {
                return exeption.NegativeExeption();
            }
            else if (!queries.CheckIsExistId(model.teacherId))
            {
                return exeption.IsExistNumberExeption();
            }
            else if (queries.CheckTextIsNull(model.teacherName))
            {
                return exeption.NullExeption();
            }
            else if (queries.CheckStringsAreInteger(model.teacherName))
            {
                return exeption.NumberExeption();
            }
            else if (queries.CheckLenghtOfStrings(model.teacherName))
            {
                return exeption.LenghtExeption();
            }
            else if (queries.CheckTextIsNull(model.teacherSurname))
            {
                return exeption.NullExeption();
            }
            else if (queries.CheckStringsAreInteger(model.teacherSurname))
            {
                return exeption.NumberExeption();
            }
            else if (queries.CheckLenghtOfStrings(model.teacherSurname))
            {
                return exeption.LenghtExeption();
            }
            else
            {
                if (UpdateRequest(model) == exeption.SuccessExeption())
                { return exeption.SuccessExeption(); }
                else { return exeption.FailtureExeption(); }
            }
        }
    }
}
