using AutoMapper;
using ObjectMappingApp.Services.Mapping;

namespace ObjectMappingApp.Services.Mapping.AutoMapper
{
    public class AutoMapperMapping : IMyMapper
    {
        private readonly IMapper _mapper;

        public AutoMapperMapping(IMapper mapper)
        {
            _mapper = mapper;
        }

        public T Map<T>(object entity) => _mapper.Map<T>(entity);
    }
}
