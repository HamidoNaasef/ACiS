using ACiS.DBContext;
using ACiS.Models;
using ACiS.Models.Repository;
using ACiS.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Hosting;
using IHostingEnvironment = Microsoft.Extensions.Hosting.IHostingEnvironment;

namespace ACiS.Controllers
{
    public class UserController : Controller
    {

         private readonly IRepository<User> dbRepo;
         private readonly IRepository<Authority> AuthorityRepo;
         private readonly IHostingEnvironment hosting;
         private readonly ApplicationDBContext dbContext;
         private readonly HttpContextAccessor session;

         public UserController(IRepository<User> _user_repo , IRepository<Authority> _AuthorityRepo, IHostingEnvironment _hosting, ApplicationDBContext _dbContext)
         {
            this.dbContext = _dbContext;
            this.dbRepo = _user_repo;
            this.AuthorityRepo = _AuthorityRepo;
            this.hosting = _hosting;
         }

        // GET: UserController
        public ActionResult Index()
        {
            return View(dbRepo.List());
        }

        // GET: UserController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UserController/Create
        public ActionResult Create()
        {
            var viewModel = new UserAuthorityVM()
            {
                authorities = AuthorityRepo.List()
            };
            return View(viewModel);
        }

        // POST: UserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UserAuthorityVM viewModel)
        {
            try
            {

                var _authority = AuthorityRepo.Find(viewModel.AuthorityId);

                var user = new User()
                {
                    Id = viewModel.Id,
                    ArabicName = viewModel.ArabicName,
                    Username = viewModel.Username,
                    Password = viewModel.Password,
                    authority = _authority

                };
                dbRepo.Add(user);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UserController/Edit/5
        public ActionResult Edit(int id)
        {
            var user = dbRepo.Find(id);
            var viewModel = new UserAuthorityVM()
            {
                Id = user.Id,
                ArabicName = user.ArabicName,
                Username = user.Username,
                AuthorityId = user.authority.Id,
                authorities = AuthorityRepo.List()
            };
            return View(viewModel);
        }

        // POST: UserController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, User editedUser)
        {
            try
            {
                editedUser.Id = id;
                dbRepo.Update(editedUser);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UserController/Delete/5
        public ActionResult Delete(int id)
        {
            var user = dbRepo.Find(id);

            return View(user);
        }

        // POST: UserController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, User user)
        {
            try
            {
                user.Id = id;
                dbRepo.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        // GET: UserController/Login/5
        public ActionResult Login()
        {
            return View(new User());
        }

        // POST: UserController/Login/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(User user)
        {
            try
            {
                var loginUser = dbContext.users.SingleOrDefault(u=> u.Username == user.Username);

                if (loginUser == null)
                {
                    ViewBag.message = "لايوجد مستخدم بهذا الاسم";
                    return RedirectToAction(nameof(Login));
                }
                else if (user.Password != loginUser.Password)
                {
                    ViewBag.message = "كلمة السر خاطئة";
                    return RedirectToAction(nameof(Login));
                }

                return Redirect("Home/Index");
            }
            catch
            {
                return View();
            }
        }
       




    }
}
