using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ObjectMappingApp.Entities
{
    [Table("orders", Schema = "sales")]
    public class Order
    {
        [Key]
        [Column("order_id")]
        public int OrderId { get; set; }

        [Column("customer_id")]
        public int? CustomerId { get; set; } // Nullable

        [Column("order_status")]
        public byte OrderStatus { get; set; } // Not nullable

        [Column("order_date")]
        public DateTime OrderDate { get; set; } // Not nullable

        [Column("required_date")]
        public DateTime RequiredDate { get; set; } // Not nullable

        [Column("shipped_date")]
        public DateTime? ShippedDate { get; set; } // Nullable

        [Column("store_id")]
        public int StoreId { get; set; }

        [Column("staff_id")]
        public int StaffId { get; set; }

        [ForeignKey("CustomerId")]
        public Customer? Customer { get; set; } // Nullable

        [ForeignKey("StoreId")]
        public Store Store { get; set; } = null!;

        [ForeignKey("StaffId")]
        public Staff Staff { get; set; } = null!;
    }
}
