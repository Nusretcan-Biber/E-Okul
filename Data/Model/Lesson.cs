using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
    public class Lesson
    {
        public int lessonId { get; set;}
        public string lessonName { get; set;}

        public Note Notes { get; set;}
        public ICollection<StudentLesson> Students { get; set;}
        public ICollection<TeacherLesson> Teachers { get; set;}
        

        
    }
}
