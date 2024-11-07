using System.ComponentModel.DataAnnotations;

namespace ssemambo_jonthan_student_web_app.Models
{
    public class house
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
