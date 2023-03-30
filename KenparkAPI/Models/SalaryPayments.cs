using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KenparkAPI.Models
{
    public class SalaryPayments
    {
        [Key]
        public int Id { get; set; }
        public int EmpId { get; set; }

        [ForeignKey("EmpId")]
        public Employee? Employee { get; set; }
        public int Year { get; set; }
        public string Month { get; set; } = string.Empty;
        public decimal Salary { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;

    }
}
