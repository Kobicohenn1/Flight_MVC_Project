using FlightProject_MVC.Data;
using FlightProject_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace FlightProject_MVC.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        private readonly FlightBookingDbContext _flightBookingDbContext;

        public TestController(FlightBookingDbContext flightBookingDbContext)
        {
            _flightBookingDbContext = flightBookingDbContext;
        }

        [HttpGet("Add")]
        public string Add()
        {
            _flightBookingDbContext.Customers.Add(new Customer()
            {
                Bookings = new List<Booking>(),
                FirstName = "Kobi",
                LastName = "Mashoo",
                Password = "12345",
                Username = "KobiHagever",
            });
            _flightBookingDbContext.SaveChanges();
            return "hello";
        }

        [HttpGet("Get")]
        public IEnumerable<Customer> Get()
        {
            return _flightBookingDbContext.Customers;
        }
    }
}
