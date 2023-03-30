using KenparkAPI.Models;

namespace KenparkAPI.Data
{
    public interface ISalaryPayment
    {
        bool PaySalary(SalaryPayments salaryPayments);

        List<SalaryPayments> GetSalaryPayments(int empId, int year);
    }
}
