using System.ComponentModel.DataAnnotations;

namespace Third_version.Models
{
    public class Student
    {
        public int Id { get; set; }
        [StringLength(30)]
        [Required]
        public string Name { get; set; }
        public int? Age { get; set; }
    }
}
