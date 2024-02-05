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
        public string Password {  get; set; }
        
        [StringLength (50)]
        public string eMail { get; set; }
        public int GradeAvarage { get; set; }


    }
}
