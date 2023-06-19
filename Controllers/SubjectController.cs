using ACiS.DBContext;
using ACiS.Models.Repository;
using ACiS.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace ACiS.Controllers
{
    public class SubjectController : Controller
    {
        private readonly IRepository<Subject> dbRepo;
        private readonly IHostingEnvironment hosting;
        private readonly ApplicationDBContext dbContext;

        public SubjectController(IRepository<Subject> _dbRepo, IHostingEnvironment _hosting, ApplicationDBContext _dbContext)
        {
            this.dbContext = _dbContext;
            this.dbRepo = _dbRepo;
            this.hosting = _hosting;
        }
        // GET: DepartmentController
        public ActionResult Index()
        {
            return View(dbRepo.List());
        }

        // GET: DepartmentController/Details/5
        public ActionResult Details(int id)
        {
            var sub = dbRepo.Find(id);
            return View(sub);
        }

        // GET: DepartmentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DepartmentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Subject subject)
        {
            try
            {
                dbRepo.Add(subject);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DepartmentController/Edit/5
        public ActionResult Edit(int id)
        {
            var sub = dbRepo.Find(id);
            return View(sub);
        }

        // POST: DepartmentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Subject subject)
        {
            try
            {
                dbRepo.Update(subject);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DepartmentController/Delete/5
        public ActionResult Delete(int id)
        {
            var sub = dbRepo.Find(id);
            return View(sub);
        }
    }
}
