using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
    public class StudentLesson
    {
        public int SId { get; set; }
        public int LId { get; set; }

        public Student Student { get; set; }
        public Lesson Lesson { get; set; }

    }
}
