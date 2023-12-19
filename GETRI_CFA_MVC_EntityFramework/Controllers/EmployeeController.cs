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

        public IActionResult Details(int id)
        {
            Employee employee = iEmployeeRepository.FetchEmployeeById(id);
            return View(employee);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            var result = this.iEmployeeRepository.InsertEmployee(employee);
            return View(result);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Employee employee = iEmployeeRepository.FetchEmployeeById(id);
            return View(employee);
        }

        [HttpPost]
        public IActionResult Edit(Employee employee)
        {
            var result = this.iEmployeeRepository.UpdateEmployee(employee);
            return View(result);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            Employee employee = iEmployeeRepository.FetchEmployeeById(id);
            return View(employee);
        }

        [HttpPost,ActionName("Delete")]
        public IActionResult ConfirmDelete(int id)
        {
            var result = iEmployeeRepository.DeleteEmployee(id);
            return RedirectToAction("Index");
        }
    }
}
