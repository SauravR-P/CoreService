using CoreService.Repository;

namespace CoreService.Service
{
    public class DbCrudOperations : IDbCrudOperations
    {
        public Task<T> CreateAsync<T>(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<T> DeleteAsync<T>(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<T> UpdateAsync<T>(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
