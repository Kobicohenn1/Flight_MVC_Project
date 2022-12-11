
using FlightProject_MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace FlightProject_MVC.Data
{
    public class FlightBookingDbContext : DbContext
    {
        public FlightBookingDbContext(DbContextOptions<FlightBookingDbContext> options) :base(options) 
        {

        }
    }
    public DbSet<Flight> Flights { get; set; }
    public DbSet<Customer> Customers { get; set; }  
    public DbSet<Booking> Bookings { get; set; }

}
