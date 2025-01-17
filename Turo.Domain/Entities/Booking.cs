using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turo.Domain.Entities
{
    public class Booking : BaseEntity<string>
    {

        // Reference to the car being booked
        public int CarId { get; set; }
        public Car? Car { get; set; }  // Navigation property to the car

        // Reference to the user who made the booking (renter)
        public int RenterId { get; set; }
        public IndividualUser? Renter { get; set; }  // Navigation property to the renter

        // Booking details
        public DateTime StartDate { get; set; }  // Date when the booking starts
        public DateTime EndDate { get; set; }  // Date when the booking ends
        public double TotalPrice { get; set; }  // Total price for the booking (calculated based on price per day * number of days)

        // Payment status
        public bool IsPaid { get; set; }  // Whether the booking has been paid for
        public string? PaymentMethod { get; set; }  // Payment method used (e.g., credit card, PayPal, etc.)
        public string? PaymentDetails { get; set; }  // Additional payment details (this could be encrypted)

        // Booking status
        public BookingStatus Status { get; set; }  // Status of the booking (e.g., Pending, Confirmed, Cancelled)

        // Timestamps
        public DateTime CreatedAt { get; set; }  // When the booking was created
        public DateTime UpdatedAt { get; set; }  // When the booking was last updated
    }

    // Enum for booking status
    public enum BookingStatus
    {
        Pending,    // Booking is pending confirmation
        Confirmed,  // Booking is confirmed
        Cancelled,  // Booking is cancelled by the renter or owner
        Completed   // Booking has been completed (the rental period has ended)
    }
}


