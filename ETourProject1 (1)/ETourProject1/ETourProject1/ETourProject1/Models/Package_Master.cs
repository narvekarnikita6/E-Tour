
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ETourProject1.Models
{
    public class Package_Master
    {
        [Key]
        public int? PkgId { get; set; }
        public string? PkgName { get; set; }
  
        public int? CatMasterId { get; set; }

        [ForeignKey("CatMasterId")]
        public Category_Master? CategoryMaster{ get; set; }
        public ICollection<Booking_Header>? BookingHeaders { get; set; }
        public ICollection<Cost_Master>? CostMaster { get; set; }
        public ICollection<Itinerary_Master>? ItineraryMaster{ get; set; }
        public ICollection<Date_Master>? DateMaster { get; set; }

    }
}
