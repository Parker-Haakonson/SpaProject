namespace SpaProject.Models
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public string assignedStaff { get; set; }

        public int month { get; set; }
        public int year { get; set; }
        public int day { get; set; }
        
        public int time { get; set; }
    }
}
