using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ObjectMappingApp.Entities
{

    [Table("brands", Schema = "production")]
    public class Brand
    {
        [Key]
        [Column("brand_id")]
        public int BrandId { get; set; }

        [Column("brand_name")]
        public string? BrandName { get; set; } // Nullable
    }
}
