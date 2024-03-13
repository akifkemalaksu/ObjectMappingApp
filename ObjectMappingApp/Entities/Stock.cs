using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ObjectMappingApp.Entities
{
    [Table("stocks", Schema = "production")]
    public class Stock
    {
        [Key]
        [Column("store_id")]
        public int StoreId { get; set; }

        [Key]
        [Column("product_id")]
        public int ProductId { get; set; }

        [Column("quantity")]
        public int Quantity { get; set; }

        [ForeignKey("StoreId")]
        public Store Store { get; set; } = null!;

        [ForeignKey("ProductId")]
        public Product Product { get; set; } = null!;
    }
}
