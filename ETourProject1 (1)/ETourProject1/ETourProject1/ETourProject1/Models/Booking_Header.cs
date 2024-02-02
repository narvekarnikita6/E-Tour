using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ETourProject1.Models
{
    public class Booking_Header
    {
        [Key]
        public int? BookingId { get; set; }
        public DateTime? BookingDate { get; set; }
        public int? NumberOfPassengers { get; set; }
        public int? TourAmount { get; set; }
        public int? Taxes { get; set; }
        public int? TotalAmount { get; set; }



        
        public int? PkgId { get; set; }

        [ForeignKey("PkgId")]
        public Package_Master? PackageMaster { get; set; }


        
        public int? DepartureId { get; set; }

        [ForeignKey("DepartureId")]
        public Date_Master? DateMaster { get; set; }


       
        public int? CustId { get; set; }

        [ForeignKey("CustId")]
        public Customer_Master? CustomerMaster { get; set; }
    }
}
