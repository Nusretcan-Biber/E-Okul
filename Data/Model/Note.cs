using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
    public class Note
    {
        
        public int NotesId { get; set; }

        public int Midterm { get; set; }

        public int Final { get; set; }

        public int Average { get; set; }

        public int StudentId {  get; set; }

        public Lesson Lesson { get; set; }

        public Student Student { get; set; }
    }
}
