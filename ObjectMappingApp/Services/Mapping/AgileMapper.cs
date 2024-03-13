using AgileObjects.AgileMapper;
using AgileObjects.AgileMapper.Extensions;
using ObjectMappingApp.Services.Mapping;

namespace ObjectMappingApp.Services.Mapping
{
    public class AgileMapper : IMyMapper
    {
        public T Map<T>(object entity) => entity.Map().ToANew<T>();
        //public T Map<T>(object entity) => Mapper.Map(entity).ToANew<T>();
    }
}
