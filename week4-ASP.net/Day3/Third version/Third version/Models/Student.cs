using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Third_version.Models
{
    public class Student
    {
        
        public int Id { get; set; }
        [StringLength(30)]
        [Required(ErrorMessage ="*")]
        public string Name { get; set; }
        [Range(10,30)]
        [Required(ErrorMessage = "Maximum age is 30")]
        public int Age { get; set; }
        [RegularExpression(@"[a-zA-Z0-9_]+@[a-zA-Z]+.[a-zA-Z]{2,4}")]
        [DataType(DataType.EmailAddress)]
        [Remote("IsEmailAvailable", "Student", HttpMethod = "POST", ErrorMessage = "Email already in use.")]
        public string Email { get; set; }
        [Required]
        [MinLength(4)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Compare("Password")]
        [NotMapped]
        public string Cpassword { get; set; }
        public int? DeptNum { get; set; }
        [ForeignKey("DeptNum")]

        public Department Department { get; set; }
    }
}
