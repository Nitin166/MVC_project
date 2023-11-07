using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.reposatry;

namespace WebApplication1.Controllers
{
    public class ParasEmployeeController : Controller
    {
        private ParasEmployeeReposatory employeereposatory;
        public ParasEmployeeController()
        {
            employeereposatory = new ParasEmployeeReposatory();
        }


        // GET: ParasEmployeeController
        public ActionResult Index()
        {
           var paremp= employeereposatory.GetAllEmployee();
            return View(paremp);
        }

        // GET: ParasEmployeeController/Details/5
        public ActionResult Details(int id)
        {
     var pa=   employeereposatory.GetById(id);
            return View(pa);
        }

        // GET: ParasEmployeeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ParasEmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ParasEmployee collection)
        {
            try
            {
                employeereposatory.InsertEmployee(collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ParasEmployeeController/Edit/5
        public ActionResult Edit(int id)
        {
         var par=   employeereposatory.GetById(id);
            return View(par);
        }

        // POST: ParasEmployeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ParasEmployee collection)
        {
            try
            {
                employeereposatory.UpdateParasEmployee(id, collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ParasEmployeeController/Delete/5
        public ActionResult Delete(int id)
        {
            var par = employeereposatory.GetById(id);
            return View(par);
        }

        // POST: ParasEmployeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, ParasEmployee collection)
        {
            try
            {
                employeereposatory.DeleteEmployee(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
