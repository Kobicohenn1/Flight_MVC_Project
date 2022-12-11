using System.ComponentModel.DataAnnotations;

namespace FlightProject_MVC.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public ICollection<Booking> Bookings { get; set; }
    }
}