using ACiS.DBContext;
using ACiS.Models.Repository;
using ACiS.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;
using ACiS.ViewModels;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ACiS.Controllers
{
    public class DivisionController : Controller
    {
        private readonly IRepository<Division> divisionRepo;
        private readonly IRepository<Department> dep_Repo;
        private readonly IHostingEnvironment hosting;
        private readonly ApplicationDBContext dbContext;

        public DivisionController(IRepository<Division> _divisionRepo,IRepository<Department> _dep_Repo, IHostingEnvironment _hosting, ApplicationDBContext _dbContext)
        {
            this.dbContext = _dbContext;
            this.divisionRepo = _divisionRepo;
            this.dep_Repo = _dep_Repo;
            this.hosting = _hosting;
        }
        // GET: DivisionController
        public ActionResult Index()
        {
            var divisionList = divisionRepo.List();
            return View(divisionList);
        }

        // GET: DivisionController/Details/5
        public ActionResult Details(int id)
        {
            var div = divisionRepo.Find(id);
            return View(div);
        }

        // GET: DivisionController/Create
        public ActionResult Create()
        {
            var viewModel = new DivisionDepartmentVM() {
                Departments = dep_Repo.List()
            };
            return View(viewModel);
        }

        // POST: DivisionController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DivisionDepartmentVM divModel)
        {
            try
            {
                var div_dep = dep_Repo.Find(divModel.DepartmentId);

                var newDiv = new Division() {
                    Id = divModel.Id,
                    AcademicCode = divModel.AcademicCode,
                    ArabicName  = divModel.ArabicName,
                    EnglishName = divModel.EnglishName,
                    department = div_dep
                };
                divisionRepo.Add(newDiv);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DivisionController/Edit/5
        public ActionResult Edit(int id)
        {
            var div = divisionRepo.Find(id);

            var viewModel = new DivisionDepartmentVM()
            {
                Id = div.Id,
                AcademicCode = div.AcademicCode,
                ArabicName = div.ArabicName,
                EnglishName = div.EnglishName,
                Departments = dep_Repo.List()
            };
            return View(viewModel);
        }

        // POST: DivisionController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, DivisionDepartmentVM ddvm)
        {
            try
            {
                var div_dep = dep_Repo.Find(ddvm.DepartmentId);

                var newDiv = new Division()
                {
                    Id = ddvm.Id,
                    AcademicCode = ddvm.AcademicCode,
                    ArabicName = ddvm.ArabicName,
                    EnglishName = ddvm.EnglishName,
                    department = div_dep
                };
                divisionRepo.Update(newDiv);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DivisionController/Delete/5
        public ActionResult Delete(int id)
        {
            var deletedDiv = divisionRepo.Find(id);
            return View(deletedDiv);
        }

        // POST: DivisionController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Division division)
        {
            try
            {
                divisionRepo.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
