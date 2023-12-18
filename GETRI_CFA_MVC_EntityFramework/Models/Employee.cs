using System.ComponentModel.DataAnnotations;

namespace GETRI_CFA_MVC_EntityFramework.Models
{
    public class Employee
    {
        [Key] public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpAddress { get; set; }
        public string EmpGender { get; set; }
        public float EmpContact { get; set; }
    }
}
