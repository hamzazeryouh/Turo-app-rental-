using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turo.Domain.Entities
{
    public class AgencyLocation
    {
        public int Id { get; set; }  // Unique identifier for the location
        public int AgencyId { get; set; }  // The agency that owns this location
        public string? Address { get; set; }  // Address of the location
        public double Latitude { get; set; }  // Latitude for geolocation
        public double Longitude { get; set; }  // Longitude for geolocation
        public string? ContactNumber { get; set; }  // Contact number for the location
        public string? OperatingHours { get; set; }  // e.g., "Mon-Sun: 9am - 6pm"

        // Navigation property
        public Agency? Agency { get; set; }  // Navigation back to the agency entity
    }
}
