using CoreService.RequestModels;

namespace CoreService.Repository
{
    public interface IDbCrudOperations
    {
        Task<T> CreateAsync<T>(T entity);
        Task<T> UpdateAsync<T>(EmployeeCreateRequestModel employee);
        Task DeleteAsync(int id);
    }
}
    