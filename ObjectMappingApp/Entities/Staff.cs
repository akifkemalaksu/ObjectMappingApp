using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ObjectMappingApp.Entities
{
    [Table("staffs", Schema = "sales")]
    public class Staff
    {
        [Key]
        [Column("staff_id")]
        public int StaffId { get; set; }

        [Column("first_name")]
        public string FirstName { get; set; } // Not nullable

        [Column("last_name")]
        public string LastName { get; set; } // Not nullable

        [Column("email")]
        public string Email { get; set; } // Not nullable

        [Column("phone")]
        public string? Phone { get; set; } // Nullable

        [Column("active")]
        public byte Active { get; set; } // Not nullable

        [Column("store_id")]
        public int StoreId { get; set; }

        [Column("manager_id")]
        public int? ManagerId { get; set; } // Nullable

        [ForeignKey("StoreId")]
        public Store Store { get; set; } = null!;

        [ForeignKey("ManagerId")]
        public Staff? Manager { get; set; } // Nullable
    }
}
