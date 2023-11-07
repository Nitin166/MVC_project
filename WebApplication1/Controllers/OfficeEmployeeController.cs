using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.reposatry;

namespace WebApplication1.Controllers
{
    public class OfficeEmployeeController : Controller
    {
        private OfficeEmployeeReposatory officeEmployeeReposatory;
        public OfficeEmployeeController()
        {
            officeEmployeeReposatory = new OfficeEmployeeReposatory();
        }
        // GET: OfficeEmployeeController
        public ActionResult Index()
        {
            var listEmployee = officeEmployeeReposatory.GetAllOfficeEmployee();
            return View(listEmployee);
        }

        // GET: OfficeEmployeeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: OfficeEmployeeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OfficeEmployeeController/Create
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

        // GET: OfficeEmployeeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: OfficeEmployeeController/Edit/5
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

        // GET: OfficeEmployeeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OfficeEmployeeController/Delete/5
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
