using System.ComponentModel.DataAnnotations;

namespace SpaProject.Models
{
    public class Register
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "First name is required.")]
        [StringLength(50, ErrorMessage = "First name cannot exceed 50 characters.")]
        public string? FirstName { get; set; }
        
        [Required(ErrorMessage = "Last name is required.")]
        [StringLength(50, ErrorMessage = "Last name cannot exceed 50 characters.")]
        public string? LastName { get; set; }
        
        [Required(ErrorMessage = "Phone number is required.")]
        [Phone(ErrorMessage = "Please enter a valid phone number.")]
        [StringLength(20, ErrorMessage = "Phone number cannot exceed 20 characters.")]
        public string? PhoneNumber { get; set; }
        
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "Email must be between 3 and 60 characters.")]
        public string? Email { get; set; }
        
        [Required(ErrorMessage = "Password is required.")]
        [StringLength(60, MinimumLength = 6, ErrorMessage = "Password must be at least 6 characters long.")]
        public string? Password { get; set; }

        public bool IsAdmin { get; set; }
    }
}
