using ACiS.DBContext;
using ACiS.Models.Repository;
using ACiS.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace ACiS.Controllers
{
    public class StudentMarksController : Controller
    {
        private readonly IRepository<SubjectsMarks> MarksRepository;
        private readonly IHostingEnvironment hosting;
        private readonly ApplicationDBContext dbContext;

        public StudentMarksController(IRepository<SubjectsMarks> _dbRepo, IHostingEnvironment _hosting, ApplicationDBContext _dbContext)
        {
            this.dbContext = _dbContext;
            this.MarksRepository = _dbRepo;
            this.hosting = _hosting;
        }
        // GET: StudentMarksController
        public ActionResult Index()
        {
            var marks = MarksRepository.List();
            return View();
        }

        // GET: StudentMarksController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StudentMarksController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentMarksController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: StudentMarksController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StudentMarksController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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

        // GET: StudentMarksController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StudentMarksController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
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
