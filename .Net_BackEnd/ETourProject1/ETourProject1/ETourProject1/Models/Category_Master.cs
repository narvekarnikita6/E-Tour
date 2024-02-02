using System.ComponentModel.DataAnnotations;
using ETourProject1.Models;



namespace ETourProject1.Models
{
    public class Category_Master
    {
        [Key]
        public int? CatMasterId { get; set; }

        public string? CatId { get; set; }

        public string? SubCatId { get; set; }

        public string? CatName { get; set; }

        public string? CatImagePath { get; set; }

        public ICollection<Package_Master>? PackageMaster { get; set; }
 
    }
}
