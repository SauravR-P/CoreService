using CoreService.RequestModels;

namespace CoreService.Repository
{
    public interface IDbCrudOperations
    {
        Task CreateAsync<T>(EmployeeCreateRequestModel employeeCreateRequestModel);
        Task<T> UpdateAsync<T>(EmployeeCreateRequestModel employee);
        Task DeleteAsync(int id);
    }
}
    