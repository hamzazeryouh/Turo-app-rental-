using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turo.Domain.Entities
{
    public class Agency : User
    {
        public string AgencyName { get; set; }  // Name of the agency
        public string AgencyLogo { get; set; }  // URL or path to the agency's logo
        public string Description { get; set; }  // Short description of the agency
        public string TaxId { get; set; }  // Tax identification number for the agency
        public string Website { get; set; }  // URL of the agency's website
        public string PhoneNumber { get; set; }  // Contact number for the agency
        public string Email { get; set; }  // Contact email for the agency


        // Navigation properties
        public ICollection<Car> CarsOwned { get; set; }  // Cars owned by the agency
    }
}
