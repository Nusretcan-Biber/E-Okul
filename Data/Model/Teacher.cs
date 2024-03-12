using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
    public class Teacher
    {

        [Key] public int teacherId { get; set; }
        public string teacherName { get; set; }
        public string teacherSurname { get; set; }
        public string teacherEmail { get; set;}
        public string teacherPassword { get; set;}
        public ICollection<TeacherLesson> lessons { get; set; }

    }
}
