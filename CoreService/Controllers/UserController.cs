using CoreService.Repository;
using CoreService.RequestModels;
using CoreService.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreService.Controllers
{
    public class UserController : Controller
    {

        private IDbCrudOperations _operations;

        public UserController()
        {
            _operations = new DbCrudOperations();

        }

        // POST: UserController/Create
        [HttpPost("CreateEmp")]
        public ActionResult Create(EmployeeCreateRequestModel requestModel)
        {
            try
            {
                _operations.CreateAsync(requestModel);
                return Ok(requestModel);
            }
            catch
            {
                return View();
            }
        }
        [HttpPost("CreateProject")]
        public ActionResult CreateProject(ProjectRequestModel requestModel)
        {
            try
            {
                _operations.CreateAsync(requestModel);
                return Ok(requestModel);
            }
            catch
            {
                return View();
            }
        }

        // GET: UserController/Edit/5
        [HttpPatch]
        public  ActionResult Edit(EmployeeCreateRequestModel employee)
        {
           _operations.UpdateAsync<EmployeeCreateRequestModel>(employee);

            return Ok(employee);
        }


        // GET: UserController/Delete/5
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            _operations.DeleteAsync(id);
            return Ok(id);

        }


    }
}
