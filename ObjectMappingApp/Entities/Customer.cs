using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ObjectMappingApp.Entities
{
    [Table("customers", Schema = "sales")]
    public class Customer
    {
        [Key]
        [Column("customer_id")]
        public int CustomerId { get; set; }

        [Column("first_name")]
        public string? FirstName { get; set; } // Nullable

        [Column("last_name")]
        public string? LastName { get; set; } // Nullable

        [Column("phone")]
        public string? Phone { get; set; } // Nullable

        [Column("email")]
        public string Email { get; set; } // Not nullable

        [Column("street")]
        public string? Street { get; set; } // Nullable

        [Column("city")]
        public string? City { get; set; } // Nullable

        [Column("state")]
        public string? State { get; set; } // Nullable

        [Column("zip_code")]
        public string? ZipCode { get; set; } // Nullable
    }
}
