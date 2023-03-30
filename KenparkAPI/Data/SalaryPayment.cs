using KenparkAPI.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;

namespace KenparkAPI.Data
{
    public class SalaryPayment : ISalaryPayment
    {
        public ApplicationDbContext _dbContext { get; }
        public SalaryPayment(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool PaySalary(SalaryPayments sp)
        {
            try
            {
                var createdDateTime = DateTime.Now;

                _dbContext.Database.ExecuteSqlRaw(
                    "EXEC sp_add_salary_payment @EmpId, @Year, @Month, @Salary, @CreatedDateTime",
                    new SqlParameter("@EmpId", sp.EmpId),
                new SqlParameter("@Year", sp.Year),
                    new SqlParameter("@Month", sp.Month),
                    new SqlParameter("@Salary", sp.Salary),
                    new SqlParameter("@CreatedDateTime", sp.CreatedDateTime));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<SalaryPayments> GetSalaryPayments(int empId, int year)
        {
            return _dbContext.SalaryPayments.FromSqlRaw(@$"SELECT * FROM SalaryPayments
WHERE EmpId = '{empId}' AND Year = '{year}'").ToList();
        }
    }
}
