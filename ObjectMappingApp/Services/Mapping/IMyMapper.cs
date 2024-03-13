namespace ObjectMappingApp.Services.Mapping
{
    public interface IMyMapper
    {
        public T Map<T>(object entity);
    }
}
