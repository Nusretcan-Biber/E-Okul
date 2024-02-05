using Businnes.Base_Services;
using Core.Check_List;
using Core.ExeptionControl;
using Data.Model;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businnes.Model_Services
{
    public class StudentService : BaseService<Student>
    {

        // sorgular burada olacak çünkü base service de gelen parametreler T tipinde 
        Queries<Student> queries = new Queries<Student>();

        Exeptions exeption = new Exeptions();
        public string StudentDeleteRequest(int studentid)
        {
            if (queries.CheckIdIsNull(studentid))
            {
                return exeption.NullExeption();
            }
            else if (queries.CheckIsIdNegative(studentid))
            {
                return exeption.NegativeExeption();
            }
            else if (!queries.CheckIsExistId(studentid))
            {
                return exeption.IsNotExistIdExeption();
            }
            else
            {
                if (DeleteRequest(studentid) == exeption.SuccessExeption())
                {
                    return exeption.SuccessExeption();
                }
                else
                {
                    return exeption.FailtureExeption();
                }
            }
        }

        public List<Student> StudentGetAllRequest()
        {
            return GetAllListRequest();
        }
        public Student StudentGetByIdRequest(int studentid)
        {
            return GetByIdRequest(studentid);
        }

        public string StudentInsertRequest(Student model)
        {
            if (queries.CheckIdIsNull(model.SudentId))
            {
                return exeption.NullExeption();
            }
            else if (queries.CheckIsIdNegative(model.SudentId))
            {
                return exeption.NegativeExeption(); 
            }
            else if (queries.CheckIsExistId(model.SudentId))
            {
                return exeption.IsExistNumberExeption();
            }
            else if (queries.CheckTextIsNull(model.StudentName))
            {
                return exeption.NullExeption();
            }
            else if (queries.CheckStringsAreInteger(model.StudentName))
            {
                return exeption.NumberExeption();
            }
            else if (queries.CheckLenghtOfStrings(model.StudentName))
            {
                return exeption.LenghtExeption();
            }
            else if (queries.CheckTextIsNull(model.StudentSurname))
            {
                return exeption.NullExeption();
            }
            else if (queries.CheckStringsAreInteger(model.StudentSurname))
            {
                return exeption.NumberExeption();
            }
            else if (queries.CheckLenghtOfStrings(model.StudentSurname))
            {
                return exeption.LenghtExeption();
            }
            else if (queries.CheckTextIsNull(model.Password))
            {
                return exeption.NullExeption();
            }
            else if (queries.CheckLenghtOfStrings(model.Password))
            {
                return exeption.LenghtExeption();
            }
            else if (queries.CheckTextIsNull(model.eMail))
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

        public string StudentUpdateRequest(Student model)
        {
            if (queries.CheckIdIsNull(model.SudentId))
            {
                return exeption.NullExeption();
            }
            else if (queries.CheckIsIdNegative(model.SudentId))
            {
                return exeption.NegativeExeption();
            }
            else if (!queries.CheckIsExistId(model.SudentId))
            {
                return exeption.IsExistNumberExeption();
            }
            else if (queries.CheckTextIsNull(model.StudentName))
            {
                return exeption.NullExeption();
            }
            else if (queries.CheckStringsAreInteger(model.StudentName))
            {
                return exeption.NumberExeption();
            }
            else if (queries.CheckLenghtOfStrings(model.StudentName))
            {
                return exeption.LenghtExeption();
            }
            else if (queries.CheckTextIsNull(model.StudentSurname))
            {
                return exeption.NullExeption();
            }
            else if (queries.CheckStringsAreInteger(model.StudentSurname))
            {
                return exeption.NumberExeption();
            }
            else if (queries.CheckLenghtOfStrings(model.StudentSurname))
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
