using System.ComponentModel.DataAnnotations;

namespace CarInsurance2.Models
{
    public class Insuree
    {

        public enum Coverage
        {
            FullCoverage,
            PartialCoverage
        }
        public Guid id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }

        public string? EmailAdress { get; set; }

        public required DateOnly DateOfBirth {  get; set; }

        [Range(1950, 2025, ErrorMessage = "Please enter a valid car year")]
        public required int CarYear { get; set; }
        public required string CarMake { get; set; }
        public required string CarModel { get; set; }
        public required bool DUI    { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Speeding tickets cannot be negative")]
        public required int SpeedingTickets     { get; set; }
        public required Coverage CoverageType  { get; set; }
        public decimal? Quote {  get; set; }


    }
}
