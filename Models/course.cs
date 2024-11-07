using System.ComponentModel.DataAnnotations;

namespace ssemambo_jonthan_student_web_app.Models
{
    public class course
    {
        [Key]
        public int Id { get; set; }
        public string CourseCode { get; set; }
        public string Name { get; set; }

    }
}
