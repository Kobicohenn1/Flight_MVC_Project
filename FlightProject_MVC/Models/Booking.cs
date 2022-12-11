using System.ComponentModel.DataAnnotations;

namespace FlightProject_MVC.Models
{
    public class Booking
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreatedTime { get; set; } = DateTime.Now;

        public Flight FlightObject { get; set; }
        public int FlightIdForeignkey { get; set; }

        public Customer CustomerObject { get; set; }   
        public int CustomerIdForeignkey { get; set; }
    }
}