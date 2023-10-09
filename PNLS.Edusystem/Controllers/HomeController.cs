using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PNLS.Edusystem.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Http;

namespace PNLS.Edusystem.Controllers
{
    public class HomeController : Controller
    {
        /*private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }*/
        private readonly AdminDbcontext Srecod;
        public HomeController(AdminDbcontext Srecod)
        {
            this.Srecod = Srecod;
         
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult DB()
        {
            return View();
        }
        public async Task <IActionResult> DashBord()
        {
           
            var stdData = await Srecod.studentsTable.ToListAsync();
           /* if (HttpContext.Session.GetString("key") != null)
            {
                ViewBag.mymessage = HttpContext.Session.GetString("loginkey").ToString();
            }
            else
            {
                return RedirectToAction("Login", "Home");
            }*/

            return View(stdData);
            
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(StudentsRecod std)
        {
            if (ModelState.IsValid)
            {
                await Srecod.studentsTable.AddAsync(std);
                await Srecod.SaveChangesAsync();
                TempData["insert_data"] = "Inserted";
                return RedirectToAction("DashBord", "Home");
            }


            return View(std);
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || Srecod.studentsTable == null)
            {
                return NotFound();
            }
            var stdData = await Srecod.studentsTable.FirstOrDefaultAsync(x => x.Id == id);
            if (stdData == null)
            {
                return NotFound();
            }
            return View(stdData);
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || Srecod.studentsTable == null)
            {
                return NotFound();
            }
            var stdData = await Srecod.studentsTable.FindAsync(id);
            if (stdData == null)
            {
                return NotFound();
            }

            return View(stdData);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, StudentsRecod st)
        {
            if (id != st.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                Srecod.studentsTable.Update(st);
                await Srecod.SaveChangesAsync();
                TempData["update_data"] = "Updated";
                return RedirectToAction("DashBord", "Home");
                 

            }
            return View(st);
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || Srecod.studentsTable == null)
            {
                return NotFound();
            }
            var stdData = await Srecod.studentsTable.FirstOrDefaultAsync(x => x.Id == id);
            if (stdData == null)
            {
                return NotFound();
            }
            return View(stdData);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirm(int? id)
        {
            var stdData = await Srecod.studentsTable.FindAsync(id);
            if (stdData != null)
            {
                Srecod.studentsTable.Remove(stdData);
            }
            await Srecod.SaveChangesAsync();
            TempData["delete_data"] = "Deleted";
            return RedirectToAction("Index", "Home");
            //return View(stdData);

        }
        public IActionResult Login()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(AdMin user)
        {
            var myuser = Srecod.adMinsTable.Where(x =>x.Email==user.Email && x.Password==user.Password).FirstOrDefault();
            if (myuser != null)
            {
                HttpContext.Session.SetString("key",myuser.Email);
                return RedirectToAction("ADMIN", "Home");
            }
            else
            {
                ViewBag.message = "LOGIN FALID";
            }

            return View();
        }
        public IActionResult ADMIN()
        {
            if (HttpContext.Session.GetString("key") != null)
            {
                ViewBag.mymessage = HttpContext.Session.GetString("key").ToString();
            }
            else
            {
                return RedirectToAction("Login", "Home");
            }
            return View();
        }
        public IActionResult Logout()
        {
            if (HttpContext.Session.GetString("key") != null)
            {
                HttpContext.Session.Remove("key");
                return RedirectToAction("Login");
            }

            return View();
        }
        public IActionResult signup()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> signup(AdMin ur)
        {
            if (ModelState.IsValid)
            {
                await Srecod.adMinsTable.AddAsync(ur);
                await Srecod.SaveChangesAsync();
                TempData["insert_data"] = "Sign up completeed";
                return RedirectToAction("signup", "Home");
            }


            return View(ur);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}