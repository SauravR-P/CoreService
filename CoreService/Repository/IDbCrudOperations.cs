namespace CoreService.Repository
{
    public interface IDbCrudOperations
    {
        Task<T> CreateAsync<T>(T entity);
        Task<T> UpdateAsync<T>(int Id);
        Task<T> DeleteAsync<T>(int Id);
    }
}
