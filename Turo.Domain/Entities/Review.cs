using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turo.Domain.Entities
{
    public class Review : BaseEntity<string>
    {
        public string AgencyId { get; set; }  // The agency being reviewed
        public string CarId { get; set; }  // Optional: The car being reviewed (if applicable)
        public string UserId { get; set; }  // The user leaving the review
        public string? Comments { get; set; }  // The text of the review
        public double Rating { get; set; }  // Rating out of 5 (or other scale)

        // Navigation properties
        public Agency? Agency { get; set; }  // Navigation back to the agency entity
        public Car? Car { get; set; }  // Navigation back to the car entity (optional)
        public User? User { get; set; }  // Navigation back to the user leaving the review
    }
}
