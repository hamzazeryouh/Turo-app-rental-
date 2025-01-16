using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turo.Domain.Entities
{
    public class User : BaseEntity<string>
    {
        public string? FirstName { get; set; }  // User's first name
        public string? LastName { get; set; }  // User's last name
        public string? Email { get; set; }  // User's email address
        public string? PhoneNumber { get; set; }  // User's phone number
        public string? Address { get; set; }  // User's address (could be used for billing or location purposes)
        public string? PasswordHash { get; set; }  // Hashed password for authentication
        public DateTime CreatedAt { get; set; }  // When the user was created
        public bool IsActive { get; set; }  // Whether the user is active or not

        // Navigation properties
        public ICollection<Booking>? Bookings { get; set; }  // List of bookings made by the user (for individual users)
        public ICollection<Car>? CarsOwned { get; set; }  // List of cars owned by the agency (if an agency)
        public ICollection<Review>? Reviews { get; set; }  // List of reviews made by the user
    }
}
    

