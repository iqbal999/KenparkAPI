using KenparkAPI.Data;
using KenparkAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KenparkAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SalaryPaymentController : ControllerBase
    {
        private readonly ISalaryPayment _service;
        public SalaryPaymentController(ISalaryPayment service)
        {
            _service = service;
        }

        [HttpGet]
        public List<SalaryPayments> GetSalaryPayments(int empId, int year)
        {
            return _service.GetSalaryPayments(empId, year);
        }

        [HttpPost]
        public bool SalaryPayment(SalaryPayments salaryPayments)
        {
            return _service.PaySalary(salaryPayments);
        }
    }
}
