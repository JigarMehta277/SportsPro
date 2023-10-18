using Microsoft.AspNetCore.Mvc;
using SportsPro.Models;

namespace SportsPro.Controllers
{
    public class IncidentController : Controller
    {
        [Route("incident")]
        public IActionResult List()
        {
            var incidents = new List<Incident>
            {
                new Incident { IncidentID = 1, CustomerID = 1, ProductID = 1, TechnicianID = 1, Title = "Issue 1", Description = "Sample issue 1", DateOpened = DateTime.Now, DateClosed = DateTime.Now.AddHours(1) },
                new Incident { IncidentID = 2, CustomerID = 2, ProductID = 2, TechnicianID = 2, Title = "Issue 2", Description = "Sample issue 2", DateOpened = DateTime.Now, DateClosed = DateTime.Now.AddHours(2) }
            };

            return View(incidents);
        }
    }
}
