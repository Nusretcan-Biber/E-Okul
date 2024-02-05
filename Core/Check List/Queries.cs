﻿using Core.ExeptionControl;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Check_List
{
    public class Queries <T> where T : class
    {

        public bool CheckIsIdNegative(int studentId) 
        {
            if (int.IsNegative(studentId)) { return true; }
            else { return false; }
        }

        public bool CheckIdIsNull(int studentId)
        {
            var check = studentId == null;

            if (check) { return true; }
            else { return false; }

        }
        public bool CheckTextIsNull(string studentName)
        {
            if (string.IsNullOrEmpty(studentName)) { return true; }
            else { return false; }
        }

        public bool CheckLenghtOfStrings(string text)
        {
            if (text.Length <= 1 &  text.Length >= 50)
            { return true; }
            else { return false; }
        }

        public bool CheckStringsAreInteger(string suspicious)
        {
            int integer = 0;
            return int.TryParse(suspicious, out integer);
        }

        public bool CheckIsExistId(int id)
        {

            Repository<T> repository = new Repository<T>();
            
            var result = repository.GetById(id);
            if (result == null) { return false;}
            else { return true; }

        }
    }
}
