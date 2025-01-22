using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turo.Domain.Entities
{
    public class MaintenanceRecord :BaseEntity<string>
    {
        public string CarId { get; set; }  // The car that underwent the maintenance
        public string? ServicePerformed { get; set; }  // Description of the service (e.g., "Oil Change", "Tire Replacement")
        public DateTime ServiceDate { get; set; }  // Date the service was performed
        public string? ServiceProvider { get; set; }  // Name of the service provider (e.g., "XYZ Auto Repair")
        public decimal Cost { get; set; }  // Cost of the service
        public string? Notes { get; set; }  // Any additional notes (e.g., "Replaced brake pads")

        // Navigation property
        public Car? Car { get; set; }  // Navigation back to the car entity
    }
}
