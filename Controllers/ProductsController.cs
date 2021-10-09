using ECommerce1.Data.Repositories;
using ECommerce1.Data.Services.Interfaces;
using ECommerce1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ECommerce1.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductsService _service;
        public ProductsController(IProductsService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllProducts();
            return View(data);
        }

        public IActionResult CreateProduct()
        {
            var productCategoriesRepo = new ProductCategoryRepository();
            var statusRepo = new StatusRepository();

            var viewModel = new Product() {
                ProductCategories = productCategoriesRepo.GetProductCategories(),
                Statuses = statusRepo.GetStatuses()
            };

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct([Bind("Name,Description")]Product product)
        {
            if (!ModelState.IsValid) 
                return View(product);

            _service.CreateProduct(product);
            return RedirectToAction(nameof(Index));
        }
    }
}
