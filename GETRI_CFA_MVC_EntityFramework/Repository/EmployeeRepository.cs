using GETRI_CFA_MVC_EntityFramework.EntityFramework;
using GETRI_CFA_MVC_EntityFramework.Models;

namespace GETRI_CFA_MVC_EntityFramework.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeDbContext employeeDbContext;

        public EmployeeRepository(EmployeeDbContext _employeeDbContext)
        {
            employeeDbContext = _employeeDbContext;
        }
        public bool DeleteEmployee(int EmpId)
        {
            var filterData = employeeDbContext.Employees.Where(x => x.EmpId == EmpId).FirstOrDefault();
            var result = employeeDbContext.Employees.Remove(filterData);
            employeeDbContext.SaveChanges();
            return result != null ? true : false;
        }

        public List<Employee> FetchAllEmployees()
        {
            return employeeDbContext.Employees.ToList();
        }

        public Employee FetchEmployeeById(int EmpId)
        {
            return employeeDbContext.Employees.Where(x => x.EmpId == EmpId).FirstOrDefault();
        }

        public Employee InsertEmployee(Employee employee)
        {
            var result = employeeDbContext.Employees.Add(employee);
            employeeDbContext.SaveChanges();
            return result.Entity;
        }

        public Employee UpdateEmployee(Employee employee)
        {
            employeeDbContext.Update<Employee>(employee);
            employeeDbContext.SaveChanges();
            return employee;
        }
    }
}
