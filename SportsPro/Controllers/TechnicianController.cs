using Microsoft.AspNetCore.Mvc;
using SportsPro.Models;

namespace SportsPro.Controllers
{
    public class TechnicianController : Controller
    {
        [Route("technician")]
        public IActionResult List()
        {
            var technicians = new List<Technician>
            {
                new Technician { TechnicianID = 1, Name = "John Doe", Email = "john@example.com", Phone = "123-456-7890" },
                new Technician { TechnicianID = 2, Name = "Jane Smith", Email = "jane@example.com", Phone = "987-654-3210" }
            };

            return View(technicians);
        }
    }
}
