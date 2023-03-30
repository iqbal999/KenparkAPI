using KenparkAPI.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace KenparkAPI.Data
{
    public class EmployeeService : IEmployeeService
    {
        public ApplicationDbContext _dbContext { get; }
        public EmployeeService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public Employee Add(Employee employee)
        {
            //var emp = _dbContext.Employees.Add(employee);
            //_dbContext.SaveChanges();
            //return emp.Entity;
            var idNumber = new SqlParameter("@IdNumber", employee.IdNumber);
            var contactNumber = new SqlParameter("@ContactNumber", employee.ContactNumber);
            var address = new SqlParameter("@Address", employee.Address);
            var activeStatus = new SqlParameter("@ActiveStatus", employee.ActiveStatus);

            _dbContext.Database.ExecuteSqlRaw("EXEC sp_add_employee @IdNumber, @ContactNumber, @Address, @ActiveStatus",
                idNumber, contactNumber, address, activeStatus);

            return employee;
        }

        public bool DeactivateEmployee(string idNumber)
        {
            //var obj = _dbContext.Employees.FirstOrDefault(e => e.EmpId == employeeId);
            //if (obj != null)
            //{
            //    obj.ActiveStatus = activeStatus;
            //    _dbContext.Employees.Update(obj);
            //    _dbContext.SaveChanges();
            //    return true;
            //}
            //return false;
            int result = _dbContext.Database.ExecuteSqlRaw(@$"UPDATE Employees
SET ActiveStatus = 0
WHERE IdNumber = '{idNumber}'");
            return result > 0;

        }

        public Employee Edit(Employee employee)
        {
            //var obj = _dbContext.Employees.FirstOrDefault(e => e.IdNumber == employee.IdNumber);
            //if (obj != null)
            //{
            //    obj.ContactNumber = employee.ContactNumber;
            //    obj.Address = employee.Address;
            //    obj.ActiveStatus = employee.ActiveStatus;
            //    _dbContext.Employees.Update(obj);
            //    _dbContext.SaveChanges();
            //    return obj;
            //}
            //return employee;
            int result = _dbContext.Database.ExecuteSqlRaw("EXEC sp_update_employee @IdNumber, @ContactNumber, @Address, @ActiveStatus",
    new SqlParameter("@IdNumber", employee.IdNumber),
    new SqlParameter("@ContactNumber", employee.ContactNumber),
    new SqlParameter("@Address", employee.Address),
    new SqlParameter("@ActiveStatus", employee.ActiveStatus));
            return result > 0 ? employee : null;
        }

        public List<Employee> GetActiveEmployeeList()
        {
            return _dbContext
                .Employees
                .FromSqlRaw("SELECT * FROM Employees WHERE ActiveStatus = 1").ToList();
        }
    }
}
