using ACiS.DBContext;
using ACiS.Models.Repository;
using ACiS.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace ACiS.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IRepository<Department> dbRepo;
        private readonly IHostingEnvironment hosting;
        private readonly ApplicationDBContext dbContext;

        public DepartmentController(IRepository<Department> _dbRepo, IHostingEnvironment _hosting, ApplicationDBContext _dbContext)
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
            var dep = dbRepo.Find(id);
            return View(dep);
        }

        // GET: DepartmentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DepartmentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Department department)
        {
            try
            {
                dbRepo.Add(department);
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
            var dep = dbRepo.Find(id);
            return View(dep);
        }

        // POST: DepartmentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Department department)
        {
            try
            {
                department.Id = id;
                dbRepo.Update(department);
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
            var dep = dbRepo.Find(id);
            return View(dep);
        }

        // POST: DepartmentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Department department)
        {
            try
            {
                dbRepo.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
