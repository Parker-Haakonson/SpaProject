using System.ComponentModel.DataAnnotations;

namespace SpaProject.Models
{
    public class Service
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }
        
        [Required(ErrorMessage = "Service name is required.")]
        public string Name { get; set; }
        
        [Required]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Please assign a staff member.")]
        public string assignedStaff { get; set; }

        [Required]
        public int month { get; set; }
        
        [Required]
        public int year { get; set; }
        
        [Required]
        public int day { get; set; }
        
        [Required]
        public int time { get; set; }
    }
}
