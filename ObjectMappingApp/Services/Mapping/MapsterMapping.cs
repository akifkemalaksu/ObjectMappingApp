using Mapster;
using ObjectMappingApp.Services.Mapping;

namespace ObjectMappingApp.Services.Mapping
{
    public class MapsterMapping : IMyMapper
    {
        public T Map<T>(object entity) => entity.Adapt<T>();
    }
}
