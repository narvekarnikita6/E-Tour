using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
//using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace ETourProject1.Models
{
    public class Date_Master
    {
        [Key]
        public int? DepartureId { get; set; }
        public DateTime? DepartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? NumberOfDays { get; set; }

        
        public int? PkgId { get; set; }

        [ForeignKey("PkgId")]
        public Package_Master? PackageMaster { get; set; }

        public ICollection<Booking_Header>? BookingHeaders { get; set; }







    }
}
