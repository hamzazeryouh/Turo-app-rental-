using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turo.Domain.Entities
{
    public class Agency : User
    {
        // Agency Location (can be a single or multiple locations)
        public ICollection<AgencyLocation>? Locations { get; set; }  // List of agency locations

        // Operating Hours and Availability
        public string? BusinessHours { get; set; }  // e.g., "Mon-Fri: 9am - 6pm"
        public bool IsAvailable { get; set; }  // Whether the agency is currently operational (closed, open for business)

        // Fleet Information
        public int TotalCars { get; set; }  // Total number of cars the agency manages
        public int AvailableCars { get; set; }  // Number of cars available for rental
        public new ICollection<Car>? CarsOwned { get; set; }  // List of cars owned by the agency

        // Pricing & Discounts
        public double DailyRentalPrice { get; set; }  // Average daily rental price
        public string? PricingStrategy { get; set; }  // e.g., "Dynamic pricing" or "Fixed pricing"
        public ICollection<DiscountOffer>? DiscountOffers { get; set; }  // List of discounts/offers provided by the agency

        // Booking Terms and Policies
        public string? CancellationPolicy { get; set; }  // Cancellation policy details
        public string? DamagePolicy { get; set; }  // Policy for car damage/accidents
        public string? InsurancePolicy { get; set; }  // Insurance coverage details for cars rented through the agency

        // Reviews & Ratings
        public double AverageRating { get; set; }  // Average user rating of the agency (based on reviews)
        public new ICollection<Review>? Reviews { get; set; }  // List of reviews for the agency

        // Staff/Employees (Optional, if you need to track staff members)
        public ICollection<Staff>? StaffMembers { get; set; }  // List of staff members working in the agency

        // Additional Features
        public bool IsVerified { get; set; }  // Indicates whether the agency is verified (trusted, certified)
        public DateTime DateFounded { get; set; }  // Date when the agency was founded
    }
}
