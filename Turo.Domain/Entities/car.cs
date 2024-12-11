using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turo.Domain.Entities
{
    public class Car
    {
        public int Id { get; set; }  // Unique identifier for the car
        public string Make { get; set; }  // Car brand (e.g., Tesla, BMW)
        public string Model { get; set; }  // Car model (e.g., Model S, X5)
        public string VIN { get; set; }  // Vehicle Identification Number (unique identifier)
        public int Year { get; set; }  // Year of manufacture
        public string LicensePlate { get; set; }  // Car's license plate number
        public string Color { get; set; }  // Color of the car
        public decimal PricePerDay { get; set; }  // Price per day for renting the car
        public bool IsAvailable { get; set; }  // Availability status of the car
        public DateTime CreatedAt { get; set; }  // When the car was added to the system
        public DateTime LastServiceDate { get; set; }  // Last maintenance/service date
        public int Mileage { get; set; }  // Total mileage of the car
        public string FuelType { get; set; }  // Fuel type (e.g., Gasoline, Electric, Hybrid)
        public string Transmission { get; set; }  // Transmission type (e.g., Automatic, Manual)
        public int Seats { get; set; }  // Number of seats
        public string CarType { get; set; }  // Type of car (e.g., Sedan, SUV, Convertible)
        public string EngineCapacity { get; set; }  // Engine capacity (e.g., 2.0L, 5.0L)
        public string Location { get; set; }  // Location where the car is parked
        public bool IsSmokingAllowed { get; set; }  // Is smoking allowed in the car?
        public bool IsPetFriendly { get; set; }  // Is the car pet-friendly?
        public bool IsLuxury { get; set; }  // Is the car classified as luxury?

        // Car Features
        public bool HasAirConditioning { get; set; }
        public bool HasGPS { get; set; }
        public bool HasBluetooth { get; set; }
        public bool HasHeatedSeats { get; set; }
        public bool HasSunroof { get; set; }
        public bool HasBackupCamera { get; set; }
        public bool HasParkAssist { get; set; }
        public bool HasRemoteStart { get; set; }

        // Insurance & Security
        public string InsuranceProvider { get; set; }
        public string InsurancePolicyNumber { get; set; }
        public DateTime InsuranceExpiryDate { get; set; }
        public string SecurityFeatures { get; set; }  // E.g., Alarm, GPS Tracking, Immobilizer

        // Pricing & Offers
        public decimal Discount { get; set; }  // Discount rate (e.g., 10% off)
        public string SpecialPricing { get; set; }  // Special pricing info (e.g., Weekend Offer)
        public bool IsDiscountApplicable { get; set; }  // Is a discount applicable?

        // Geo-Location & Availability
        public double Latitude { get; set; }  // Latitude for geolocation
        public double Longitude { get; set; }  // Longitude for geolocation
        public DateTime AvailabilityStartDate { get; set; }  // When the car is available from
        public DateTime AvailabilityEndDate { get; set; }  // When the car is available until

        // Photos and Media
        public ICollection<CarPhoto> Photos { get; set; }  // Multiple car photos
        //public ICollection<CarVideo> Videos { get; set; }  // Videos for the car

        // Documents
        public string RegistrationDocument { get; set; }  // URL or path to registration document
        public string InsuranceDocument { get; set; }  // URL or path to insurance document

        // Maintenance and condition tracking
        public string Condition { get; set; }  // Car condition (e.g., Excellent, Good, Fair)
        public ICollection<MaintenanceRecord> MaintenanceRecords { get; set; }  // Maintenance records
        public bool NeedsMaintenance { get; set; }  // Flag to indicate if the car needs maintenance

        // Navigation properties
        public User Owner { get; set; }  // The user who owns the car
        public ICollection<Booking> Bookings { get; set; }  // Bookings associated with this car
        public ICollection<Review> Reviews { get; set; }  // Reviews for this car
    }
}
