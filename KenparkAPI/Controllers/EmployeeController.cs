using KenparkAPI.Data;
using KenparkAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KenparkAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _service;
        public EmployeeController(IEmployeeService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Employee> GetActiveEmployeeList()
        {
            return _service.GetActiveEmployeeList();
        }

        [HttpPost]
        public Employee Add(Employee employee)
        {
            return _service.Add(employee);
        }

        [HttpPost]
        public Employee Edit(Employee employee)
        {
            return _service.Edit(employee);
        }

        [HttpPost]  
        public bool DeactivateEmployee(string idNumber)
        {
            return _service.DeactivateEmployee(idNumber);
        }
    }
}
