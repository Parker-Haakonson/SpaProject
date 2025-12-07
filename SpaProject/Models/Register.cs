using System.ComponentModel.DataAnnotations;

namespace SpaProject.Models
{
    public class Register
    {
        public int Id { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 6)]
        public string? Email { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 6)]
        public string? Password { get; set; }

    }
}
