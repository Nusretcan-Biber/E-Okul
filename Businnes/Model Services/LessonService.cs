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
    public class LessonService : BaseService<Lesson>
    {

        Queries<Lesson> queries = new Queries<Lesson>();

        Exeptions exeption = new Exeptions();


        public string LessonDeleteRequest(int id)
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
        public List<Lesson> LessonGetAllRequest()
        {
            return GetAllListRequest();
        }

        public Lesson LessonGetByIdRequest(int id)
        {
            return GetByIdRequest(id);
        }

        public string LessonInsertRequest(Lesson model)
        {
            if (Extensions.CheckNumberIsNull(model.lessonId))
            {
                return exeption.NullExeption();
            }
            else if (queries.CheckIsNumberNegative(model.lessonId))
            {
                return exeption.NegativeExeption();
            }
            else if (queries.CheckIsExistId(model.lessonId))
            {
                return exeption.IsExistIdExeption();
            }
            else if (queries.CheckTextIsNull(model.lessonName))
            {
                return exeption.NullExeption();
            }
            else if (queries.CheckStringsAreInteger(model.lessonName))
            {
                return exeption.NumberExeption();
            }
            else if (queries.CheckLenghtOfStrings(model.lessonName))
            {
                return exeption.LenghtExeption();
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

        public string LessonUpdateRequest(Lesson model)
        {
            if (Extensions.CheckNumberIsNull(model.lessonId))
            {
                return exeption.NullExeption();
            }
            else if (queries.CheckIsNumberNegative(model.lessonId))
            {
                return exeption.NegativeExeption();
            }
            else if (!queries.CheckIsExistId(model.lessonId))
            {
                return exeption.IsExistNumberExeption();
            }
            else if (queries.CheckTextIsNull(model.lessonName))
            {
                return exeption.NullExeption();
            }
            else if (queries.CheckStringsAreInteger(model.lessonName))
            {
                return exeption.NumberExeption();
            }
            else if (queries.CheckLenghtOfStrings(model.lessonName))
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
