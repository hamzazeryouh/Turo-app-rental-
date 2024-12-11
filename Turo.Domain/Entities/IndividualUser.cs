using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turo.Domain.Entities
{
    public class IndividualUser
    {
        public string ProfilePicture { get; set; }  // Optional profile picture for the renter
        public ICollection<Booking> Bookings { get; set; }  // List of bookings made by the individual user
        public ICollection<Review> Reviews { get; set; }  // List of reviews left by the individual user
    }
}
