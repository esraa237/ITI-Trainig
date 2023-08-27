using System.ComponentModel.DataAnnotations;

namespace Second_project.Models
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
