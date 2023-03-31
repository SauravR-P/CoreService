using CoreService.Repository;
using CoreService.RequestModels;

namespace CoreService.Service
{
    public class DbCrudOperations : IDbCrudOperations
    {
        public Task<T> CreateAsync<T>(T entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<T> UpdateAsync<T>(EmployeeCreateRequestModel employee)
        {
            throw new NotImplementedException();
        }
    }
}
