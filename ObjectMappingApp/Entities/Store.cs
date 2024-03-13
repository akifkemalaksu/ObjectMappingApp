using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ObjectMappingApp.Entities
{
    [Table("stores", Schema = "sales")]
    public class Store
    {
        [Key]
        [Column("store_id")]
        public int StoreId { get; set; }

        [Column("store_name")]
        public string StoreName { get; set; } // Not nullable

        [Column("phone")]
        public string? Phone { get; set; } // Nullable

        [Column("email")]
        public string? Email { get; set; } // Nullable

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
