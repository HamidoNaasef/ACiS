using ACiS.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ACiS.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(new User());
        }
        // POST: UserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(User user)
        {
            Console.WriteLine("Post is Working");
            return View();
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

        
        // GET: DepartmentController/Create
        public ActionResult ControlHomePage()
        {
            return View();
        }

        // POST: DepartmentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ControlHomePage(GradingCriteria entity)
        {
            try
            {
                

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}