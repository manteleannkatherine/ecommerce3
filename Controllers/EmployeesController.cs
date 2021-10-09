using ECommerce1.Data.Services.Interfaces;
using ECommerce1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ECommerce1.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly IEmployeesService _service;
        public EmployeesController(IEmployeesService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllEmployees();
            return View(data);
        }

        [HttpPost]
        public async Task<IActionResult> CreateEmployee([Bind("EmployeeFirstName,EmployeeLastName")] Employees employees)
        {
            if (!ModelState.IsValid)
                return View(employees);

            _service.CreateEmployee(employees);
            return RedirectToAction(nameof(Index));
        }
    }
}
