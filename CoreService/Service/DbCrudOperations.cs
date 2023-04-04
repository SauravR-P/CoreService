using CoreService.MQ;
using CoreService.Repository;
using CoreService.RequestModels;
using Microsoft.AspNetCore.Mvc;

namespace CoreService.Service
{
    public class DbCrudOperations : IDbCrudOperations
    {
        private IRabbitManager _rabbitManager;


        public DbCrudOperations(IRabbitManager rabbitManager)
        {
            _rabbitManager = rabbitManager;
        }
        public Task CreateAsync<T>(EmployeeCreateRequestModel employeeCreateRequestModel) 
        {
            try

            {
                var msg = employeeCreateRequestModel;
                _rabbitManager.Publish(msg, "EmployeeExchange", "topic", "Create");
                //_rabbitManager.SendCreateMessage(msg);
                return Task.CompletedTask;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }
        Task<T> IDbCrudOperations.UpdateAsync<T>(EmployeeCreateRequestModel employee)
        {
            throw new NotImplementedException();
        }
    }
}
