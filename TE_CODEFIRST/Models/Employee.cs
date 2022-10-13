using System.ComponentModel.DataAnnotations;

namespace TE_CODEFIRST.Models
{
    public class Employee
    {
        [Key]
        public int Eid { get; set; }
        public string Ename { get; set; }
        public int EmployeeAge { get; set; }
        public DateTime DOB { get; set; }
        

    }
}
