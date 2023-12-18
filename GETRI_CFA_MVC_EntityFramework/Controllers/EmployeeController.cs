using GETRI_CFA_MVC_EntityFramework.Models;
using GETRI_CFA_MVC_EntityFramework.Repository;
using Microsoft.AspNetCore.Mvc;

namespace GETRI_CFA_MVC_EntityFramework.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository iEmployeeRepository;

        public EmployeeController(IEmployeeRepository _iEmployeeRepository)
        {
            iEmployeeRepository = _iEmployeeRepository;
        }
        public IActionResult Index()
        {
            List<Employee> lstEmployee = iEmployeeRepository.FetchAllEmployees();
            return View(lstEmployee);
        }
    }
}
