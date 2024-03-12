using System.ComponentModel.DataAnnotations;

namespace Data.Model
{
    public class Student
    {
        [Key]
        public int SudentId { get; set; } 

        [StringLength(50)]
        public string StudentName { get; set; }
        
        [StringLength(50)]
        public string StudentSurname { get; set; }

        [StringLength(50)]
        public string studentPassword {  get; set; }
        
        [StringLength (50)]
        public string eMail { get; set; }
        public int GradeAvarage { get; set; }
        public ICollection<Note> Notes { get; set; }
        public ICollection<StudentLesson> Lessons { get; set; }


    }
}
