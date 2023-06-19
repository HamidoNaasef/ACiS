using ACiS.DBContext;
using ACiS.Models.Repository;
using ACiS.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace ACiS.Controllers
{
    public class GradingCriteriaController : Controller
    {
        private readonly IRepository<GradingCriteria> dbRepo;
        private readonly IHostingEnvironment hosting;
        private readonly ApplicationDBContext dbContext;

        public GradingCriteriaController(IRepository<GradingCriteria> _dbRepo, IHostingEnvironment _hosting, ApplicationDBContext _dbContext)
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
            var grd = dbRepo.Find(id);
            return View(grd);
        }

        // GET: DepartmentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DepartmentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(GradingCriteria entity)
        {
            try
            {
                dbRepo.Add(entity);
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
            var grd = dbRepo.Find(id);
            return View(grd);
        }

        // POST: DepartmentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, GradingCriteria entity)
        {
            try
            {
                entity.Id = id;
                dbRepo.Update(entity);
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
            var grd = dbRepo.Find(id);
            return View(grd);
        }
    }
}
