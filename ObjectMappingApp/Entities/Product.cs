using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ObjectMappingApp.Entities
{
    [Table("products", Schema = "production")]
    public class Product
    {
        [Key]
        [Column("product_id")]
        public int ProductId { get; set; }

        [Column("product_name")]
        public string? ProductName { get; set; } // Nullable

        [Column("brand_id")]
        public int BrandId { get; set; }

        [Column("category_id")]
        public int CategoryId { get; set; }

        [Column("model_year")]
        public short ModelYear { get; set; }

        [Column("list_price")]
        public decimal ListPrice { get; set; }

        [ForeignKey("CategoryId")]
        public Category Category { get; set; } = null!;

        [ForeignKey("BrandId")]
        public Brand Brand { get; set; } = null!;
    }
}
