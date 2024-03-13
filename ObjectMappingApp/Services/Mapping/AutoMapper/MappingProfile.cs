using AutoMapper;
using ObjectMappingApp.Entities;
using ObjectMappingApp.Dtos;

namespace ObjectMappingApp.Services.Mapping.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductDto>();
            CreateMap<Brand, BrandDto>();
            CreateMap<Category, CategoryDto>();
            CreateMap<OrderItem, OrderItemDto>();
            CreateMap<Order, OrderDto>();
            CreateMap<Customer, CustomerDto>();
            CreateMap<Store, StoreDto>();
            CreateMap<Staff, StaffDto>();
        }
    }
}
