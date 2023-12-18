using GETRI_CFA_MVC_EntityFramework.Models;

namespace GETRI_CFA_MVC_EntityFramework.Repository
{
    public interface IEmployeeRepository
    {
        List<Employee> FetchAllEmployees();
        Employee FetchEmployeeById(int EmpId);
        Employee InsertEmployee(Employee employee);
        Employee UpdateEmployee(Employee employee);
        bool DeleteEmployee(int EmpId);
    }
}
