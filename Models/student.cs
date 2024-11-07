using System.ComponentModel.DataAnnotations;

namespace ssemambo_jonthan_student_web_app.Models
{
    public class student
    {
        [Key]
        public int Id { get; set; }
        public string RegNo { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Nationality { get; set; }
        public int Year { get; set; }
        public string Semester { get; set; }
       
    }
}
