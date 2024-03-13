using ObjectMappingApp.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ObjectMappingApp.Dtos
{
    public class OrderItemDto
    {
        public int OrderId { get; set; }

        public int ItemId { get; set; }

        public int ProductId { get; set; }

        public int Quantity { get; set; }

        public decimal ListPrice { get; set; }

        public decimal Discount { get; set; }

        public OrderDto Order { get; set; }

        public ProductDto Product { get; set; }
    }

    public class OrderDto
    {
        public int OrderId { get; set; }

        public int CustomerId { get; set; }

        public byte OrderStatus { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime RequiredDate { get; set; }

        public DateTime? ShippedDate { get; set; }

        public int StoreId { get; set; }

        public int StaffId { get; set; }

        public  CustomerDto Customer { get; set; }

        public  StoreDto Store { get; set; }

        public  StaffDto Staff { get; set; }
    }

    public class CustomerDto
    {
        public int CustomerId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Street { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string ZipCode { get; set; }
    }

    public class StoreDto
    {
        public int StoreId { get; set; }

        public string StoreName { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Street { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string ZipCode { get; set; }
    }

    public class StaffDto
    {
        public int StaffId { get; set; }

        public string FirstName { get; set; }
        
        public string LastName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public byte Active { get; set; }

        public int StoreId { get; set; }

        public int? ManagerId { get; set; }

        public StoreDto Store { get; set; }
    }
}
