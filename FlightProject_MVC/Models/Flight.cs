using System.ComponentModel.DataAnnotations;

namespace FlightProject_MVC.Models
{
    public class Flight
    {
        [Key]
        public int Id { get; set; } 
        public string FlightOrigin { get; set; }    
        public string FlightDestination { get; set; }
        public int Capacity { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime ArraivalDate { get; set; }
        public ICollection<Booking> Bookings { get; set; } = new List<Booking>();
    }
}