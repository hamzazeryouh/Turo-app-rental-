using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turo.Domain.Entities
{
    public class CarPhoto : BaseEntity<string>
    {
        public string CarId { get; set; }  // The car that the video belongs to
        public string? Url { get; set; }  // URL or path to the video file
        public string? Description { get; set; }  // Description for the video
        public DateTime CreatedAt { get; set; }  // When the video was uploaded

        // Navigation property
        public Car? Car { get; set; }  // Navigation back to the car entity
    }
}
