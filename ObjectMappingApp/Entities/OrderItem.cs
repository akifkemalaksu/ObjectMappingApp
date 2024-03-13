using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ObjectMappingApp.Entities
{
    [Table("order_items", Schema = "sales")]
    public class OrderItem
    {
        [Key]
        [Column("order_id")]
        public int OrderId { get; set; }

        [Key]
        [Column("item_id")]
        public int ItemId { get; set; }

        [Column("product_id")]
        public int ProductId { get; set; }

        [Column("quantity")]
        public int Quantity { get; set; }

        [Column("list_price")]
        public decimal ListPrice { get; set; }

        [Column("discount")]
        public decimal Discount { get; set; }

        [ForeignKey("OrderId")]
        public Order Order { get; set; } = null!;

        [ForeignKey("ProductId")]
        public Product Product { get; set; } = null!;
    }
}
