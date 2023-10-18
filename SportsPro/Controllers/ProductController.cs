using Microsoft.AspNetCore.Mvc;
using SportsPro.Models;

namespace SportsPro.Controllers
{
    public class ProductController : Controller
    {
        [Route("product")]
        public IActionResult List()
        {
            var products = new List<Product>
            {
                new Product { ProductID = 1, ProductCode = "P001", Name = "Sample Product 1", YearlyPrice = 100.00m, ReleaseDate = DateTime.Now },
                new Product { ProductID = 2, ProductCode = "P002", Name = "Sample Product 2", YearlyPrice = 75.00m, ReleaseDate = DateTime.Now }
            };

            return View(products);
        }
    }
}
