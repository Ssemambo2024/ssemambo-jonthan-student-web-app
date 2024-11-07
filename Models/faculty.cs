using System.ComponentModel.DataAnnotations;

namespace ssemambo_jonthan_student_web_app.Models
{
    public class faculty
    {
        [Key]
        public int id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
    }
}
