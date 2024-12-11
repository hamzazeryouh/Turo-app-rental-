using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turo.Domain.Entities
{
    public class Staff
    {
        public int Id { get; set; }  // Unique identifier for the staff member
        public int AgencyId { get; set; }  // The agency where the staff works
        public string FirstName { get; set; }  // First name of the staff member
        public string LastName { get; set; }  // Last name of the staff member
        public string Position { get; set; }  // Position (e.g., "Manager", "Support Staff")
        public string Email { get; set; }  // Contact email for the staff member
        public string PhoneNumber { get; set; }  // Contact phone number for the staff member

        // Navigation property
        public Agency Agency { get; set; }  // Navigation back to the agency entity
    }
}
