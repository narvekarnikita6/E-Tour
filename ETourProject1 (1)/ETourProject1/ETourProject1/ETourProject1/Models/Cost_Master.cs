using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ETourProject1.Models
{
    public class Cost_Master
    {
        [Key]
        public int? CostId { get; set; }

        public int? Cost { get; set; }


        public int? SinglePersonCost { get; set; }


        public int? ExtraPersonCost { get; set; }

        public int? ChildWithBed { get; set; }


        public int? ChildWithoutBed { get; set; }

 
        public DateTime? ValidFrom { get; set; }

        public DateTime? ValidTo { get; set; }

        
        public int? PkgId { get; set; }

        [ForeignKey("PkgId")]
        public Package_Master? PackageMaster { get; set; }

    }
}
