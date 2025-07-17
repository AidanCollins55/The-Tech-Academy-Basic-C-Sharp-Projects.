using System;
using System.ComponentModel.DataAnnotations;

namespace CarInsurance.Models
{
    public class Insuree
    {
        public int Id { get; set; } // Unique identifier for the insuree

        [Required]
        public required string FirstName { get; set; } // First name of the insuree

        [Required]
        public required string LastName { get; set; } // Last name of the insuree

        [Required]
        [EmailAddress]
        public required string EmailAddress { get; set; } // Email address of the insuree

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; } // Date of birth of the insuree

        [Required]
        public int CarYear { get; set; }    // Year of the car

        [Required]
        public required string CarMake { get; set; } // Make of the car (e.g., Toyota, Ford)

        [Required]
        public required string CarModel { get; set; } // Model of the car (e.g., Camry, Focus)

        [Required]
        public bool DUI { get; set; } // Indicates if the insuree has a DUI

        [Required]
        public int SpeedingTickets { get; set; } // Number of speeding tickets the insuree has

        [Required]
        public required string CoverageType { get; set; } // "Basic" or "Full"

        public decimal Quote { get; set; } // Calculated insurance quote for the insuree
    }
}