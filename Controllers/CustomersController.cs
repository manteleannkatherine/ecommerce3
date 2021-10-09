using ECommerce1.Data.Services.Interfaces;
using ECommerce1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ECommerce1.Controllers
{
    public class CustomersController : Controller
    {
        private readonly ICustomersService _service;
        public CustomersController(ICustomersService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllCustomers();
            return View(data);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCustomer([Bind("Name,Description")] Customers customers)
        {
            if (!ModelState.IsValid)
                return View(customers);

            _service.CreateCustomer(customers);
            return RedirectToAction(nameof(Index));
        }
    }
}
