using Nelibur.ObjectMapper;
using ObjectMappingApp.Entities;
using ObjectMappingApp.Dtos;
using ObjectMappingApp.Services.Mapping;

namespace ObjectMappingApp.Services.Mapping
{
    public class TinyMapperMapping : IMyMapper
    {
        public TinyMapperMapping()
        {
            TinyMapper.Bind<List<Product>, List<ProductDto>>();
            TinyMapper.Bind<List<OrderItem>, List<OrderItemDto>>();
            TinyMapper.Bind<Product, ProductDto>();
            TinyMapper.Bind<Brand, BrandDto>();
            TinyMapper.Bind<Category, CategoryDto>();
            TinyMapper.Bind<OrderItem, OrderItemDto>();
            TinyMapper.Bind<Order, OrderDto>();
            TinyMapper.Bind<Customer, CustomerDto>();
            TinyMapper.Bind<Store, StoreDto>();
            TinyMapper.Bind<Staff, StaffDto>();
        }
        public T Map<T>(object entity) => TinyMapper.Map<T>(entity);
    }
}
