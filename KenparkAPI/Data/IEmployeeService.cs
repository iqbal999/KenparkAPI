using KenparkAPI.Models;

namespace KenparkAPI.Data
{
    public interface IEmployeeService
    {
        Employee Add(Employee employee);
        Employee Edit(Employee employee);
        bool DeactivateEmployee(string idNumber);
        List<Employee> GetActiveEmployeeList();

    }
}
