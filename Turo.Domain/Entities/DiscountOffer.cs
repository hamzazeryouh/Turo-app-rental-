using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turo.Domain.Entities
{
    public class DiscountOffer
    {
        public int Id { get; set; }  // Unique identifier for the offer
        public int AgencyId { get; set; }  // The agency providing the offer
        public decimal DiscountPercentage { get; set; }  // Discount percentage (e.g., 15%)
        public DateTime StartDate { get; set; }  // When the offer starts
        public DateTime EndDate { get; set; }  // When the offer ends
        public string? OfferDetails { get; set; }  // Description of the offer

        // Navigation property
        public Agency? Agency { get; set; }  // Navigation back to the agency entity
    }
}
