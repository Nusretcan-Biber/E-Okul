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
    public class NoteService : BaseService<Note>
    {

        Queries<Note> queries = new Queries<Note>();

        Exeptions exeption = new Exeptions();


        public string NoteDeleteRequest(int noteId)
        {
            if (Extensions.CheckNumberIsNull(noteId))
            {
                return exeption.NullExeption();
            }
            else if (queries.CheckIsNumberNegative(noteId))
            {
                return exeption.NegativeExeption();
            }
            else if (!queries.CheckIsExistId(noteId))
            {
                return exeption.IsNotExistIdExeption();
            }
            else
            {
                if (DeleteRequest(noteId) == exeption.SuccessExeption())
                {
                    return exeption.SuccessExeption();
                }
                else
                {
                    return exeption.FailtureExeption();
                }
            }

        }

        public List<Note> NoteGetAllRequest()
        {
            return GetAllListRequest();
        }
        
        public Note NoteGetByIdRequest(int noteId)
        {
            return GetByIdRequest(noteId);
        }

        public string NoteInsertRequest(Note model)
        {
            if (Extensions.CheckNumberIsNull(model.NotesId))
            {
                return exeption.NullExeption();
            }
            else if (queries.CheckIsNumberNegative(model.NotesId))
            {
                return exeption.NegativeExeption();
            }
            else if (queries.CheckIsExistId(model.NotesId))
            {
                return exeption.IsExistIdExeption();
            }
            else if (queries.CheckIsNumberNegative(model.Midterm))
            {
                return exeption.NegativeExeption();
            }
            else if (queries.CheckIsCorrectRange(model.Midterm))
            {
                return exeption.WrongRangeExeption();
            }
            else if (queries.CheckIsNumberNegative(model.Final))
            {
                return exeption.NegativeExeption();
            }
            else if (queries.CheckIsCorrectRange(model.Final))
            {
                return exeption.WrongRangeExeption();
            }
            else if (queries.CheckIsNumberNegative(model.Average))
            {
                return exeption.NegativeExeption();
            }
            else if (queries.CheckIsCorrectRange(model.Average))
            {
                return exeption.WrongRangeExeption();
            }
            else if (Extensions.CheckNumberIsNull(model.StudentId))
            {
                return exeption.NullExeption();
            }
            else if (queries.CheckIsNumberNegative(model.StudentId))
            {
                return exeption.NegativeExeption();
            }
            else if (queries.CheckIsExistId(model.StudentId))
            {
                return exeption.IsExistNumberExeption();
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

        public string NoteUpdateRequest(Note model)
        {
            if (Extensions.CheckNumberIsNull(model.NotesId))
            {
                return exeption.NullExeption();
            }
            else if (queries.CheckIsNumberNegative(model.NotesId))
            {
                return exeption.NegativeExeption();
            }
            else if (!queries.CheckIsExistId(model.NotesId))
            {
                return exeption.IsNotExistIdExeption();
            }
            else if (queries.CheckIsNumberNegative(model.Midterm))
            {
                return exeption.NegativeExeption();
            }
            else if (queries.CheckIsCorrectRange(model.Midterm))
            {
                return exeption.WrongRangeExeption();
            }
            else if (queries.CheckIsNumberNegative(model.Final))
            {
                return exeption.NegativeExeption();
            }
            else if (queries.CheckIsCorrectRange(model.Final))
            {
                return exeption.WrongRangeExeption();
            }
            else if (queries.CheckIsNumberNegative(model.Average))
            {
                return exeption.NegativeExeption();
            }
            else if (queries.CheckIsCorrectRange(model.Average))
            {
                return exeption.WrongRangeExeption();
            }
            else if (Extensions.CheckNumberIsNull(model.StudentId))
            {
                return exeption.NullExeption();
            }
            else if (queries.CheckIsNumberNegative(model.StudentId))
            {
                return exeption.NegativeExeption();
            }
            else if (queries.CheckIsExistId(model.StudentId))
            {
                return exeption.IsExistNumberExeption();
            }
            else
            {
                if (UpdateRequest(model) == exeption.SuccessExeption())
                {
                    return exeption.SuccessExeption();
                }
                else
                {
                    return exeption.FailtureExeption();
                }
            }

        }
    }
}
