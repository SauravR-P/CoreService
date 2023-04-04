using System.ComponentModel.DataAnnotations;

namespace CoreService.RequestModels
{
    public class EmployeeCreateRequestModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public EmployeeCreateRequestModel()
        {
            
        }
    }
}
