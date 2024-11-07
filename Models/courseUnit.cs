using System.ComponentModel.DataAnnotations;

namespace ssemambo_jonthan_student_web_app.Models
{
    public class courseUnit
    {
        [Key]
        public int Id { get; set; }
        public string CourseUnitCode { get; set; }
        public string Name { get; set; }
        public string DoneInYear { get; set; }
    }
}
