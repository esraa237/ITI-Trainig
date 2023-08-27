using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Third_version.Models
{
    public class Student
    {
        
        public int Id { get; set; }
        [StringLength(30)]
        [Required]
        public string Name { get; set; }
        public int? Age { get; set; }
        public int? DeptNum { get; set; }
        [ForeignKey("DeptNum")]

        public Department Department { get; set; }
    }
}
