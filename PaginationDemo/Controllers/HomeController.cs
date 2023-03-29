using Microsoft.AspNetCore.Mvc;
using PaginationDemo.Data;
using PaginationDemo.Models;
using System.Diagnostics;

namespace PaginationDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDBContext  _dbContext;
        public HomeController(ILogger<HomeController> logger, ApplicationDBContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public IActionResult Index(int? pageNumber)
        {
            int pageSize = 7;
            var result = PaginatedList<Customer>.Create(_dbContext.Customers.ToList(), pageNumber ?? 1,pageSize);
            return View(result);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}