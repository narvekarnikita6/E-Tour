using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ETourProject1.Models
{
    public class Itinerary_Master
    {
        [Key]

        public int? ItrId { get; set; }


        public int? DayNo { get; set; }

        public string? ItrDtl { get; set; }

       
        public int? PkgId { get; set; }

        [ForeignKey("PkgId")]
        public Package_Master? PackageMaster { get; set; }
    }
}
