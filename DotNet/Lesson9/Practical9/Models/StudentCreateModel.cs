using System.ComponentModel.DataAnnotations;
namespace Practical9.Models
{
    public class StudentCreateModel
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; } = "";

        [Range(16, 120)]
        public int Age { get; set; }
    }
}