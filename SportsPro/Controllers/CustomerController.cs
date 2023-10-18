using Microsoft.AspNetCore.Mvc;
using SportsPro.Models;

namespace SportsPro.Controllers
{
    public class CustomerController : Controller
    {
        [Route("customer")]
        public IActionResult List()
        {
            var customers = new List<Customer>
            {
                new Customer { CustomerID = 1, FirstName = "Alice", LastName = "Johnson", Address = "123 Main St", City = "Cityville", State = "ST", PostalCode = "12345", CountryID = 1, Phone = "555-123-4567", Email = "alice@example.com" },
                new Customer { CustomerID = 2, FirstName = "Bob", LastName = "Smith", Address = "456 Elm St", City = "Townton", State = "ST", PostalCode = "67890", CountryID = 2, Phone = "555-987-6543", Email = "bob@example.com" }
            };

            return View(customers);
        }
    }
}
