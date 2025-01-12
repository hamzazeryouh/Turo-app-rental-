using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turo.Application.Dtos.Cars
{
    public class CarDto
    {
        public int Id { get; set; }  // Unique identifier for the car
        public string? Make { get; set; }  // Car brand (e.g., Tesla, BMW)
        public string? Model { get; set; }  // Car model (e.g., Model S, X5)
        public string? VIN { get; set; }  // Vehicle Identification Number
        public int? Year { get; set; }  // Year of manufacture
        public string? LicensePlate { get; set; }  // License plate number
        public string? Color { get; set; }  // Color of the car
        public decimal PricePerDay { get; set; }  // Rental price per day
        public bool IsAvailable { get; set; }  // Availability status
        public int Mileage { get; set; }  // Total mileage
        public string? FuelType { get; set; }  // Fuel type (e.g., Gasoline, Electric)
        public string? Transmission { get; set; }  // Transmission type
        public int Seats { get; set; }  // Number of seats
        public string? CarType { get; set; }  // Type of car (e.g., Sedan, SUV)
        public string? EngineCapacity { get; set; }  // Engine capacity (e.g., 2.0L, 5.0L)
        public string? Location { get; set; }  // Location where the car is parked
        public bool IsSmokingAllowed { get; set; }  // Is smoking allowed in the car?
        public bool IsPetFriendly { get; set; }  // Is the car pet-friendly?
        public bool IsLuxury { get; set; }  // Luxury classification

        // Car Features
        public bool HasAirConditioning { get; set; }
        public bool HasGPS { get; set; }
        public bool HasBluetooth { get; set; }
        public bool HasHeatedSeats { get; set; }
        public bool HasSunroof { get; set; }
        public bool HasBackupCamera { get; set; }
        public bool HasParkAssist { get; set; }
        public bool HasRemoteStart { get; set; }

        // Pricing & Offers
        public decimal Discount { get; set; }  // Discount rate
        public bool IsDiscountApplicable { get; set; }  // Discount applicability

        // Geo-Location
        public double Latitude { get; set; }  // Geolocation latitude
        public double Longitude { get; set; }  // Geolocation longitude

        // Media
        public ICollection<string>? PhotoUrls { get; set; }  // URLs for car photos

        // Ratings and Reviews
        public double AverageRating { get; set; }  // Average rating of the car
        public int ReviewCount { get; set; }  // Number of reviews
    }
}
