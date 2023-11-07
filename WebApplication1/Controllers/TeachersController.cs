using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.reposatry;

namespace WebApplication1.Controllers
{
    public class TeachersController : Controller
    {
        private TeachersReposatory teachersreposatory;
        public TeachersController()
        {
            teachersreposatory = new TeachersReposatory();
        }
        // GET: TeachersController
        public ActionResult Index()
        {
          var teach=  teachersreposatory.GetAllTeachers();
            return View(teach);
        }

        // GET: TeachersController/Details/5
        public ActionResult Details(int id)
        {
            var temp = teachersreposatory.GetById(id);
            return View(temp);
        }

        // GET: TeachersController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TeachersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Teachers collection)
        {
            try
            {
                teachersreposatory.Insert(collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TeachersController/Edit/5
        public ActionResult Edit(int id)
        {
            var Temp = teachersreposatory.GetById(id);
            return View(Temp);
        }

        // POST: TeachersController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Teachers collection)
        {
            try
            {
                teachersreposatory.UpdateTeachers(id, collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TeachersController/Delete/5
        public ActionResult Delete(int id)
        {
            var emplo = teachersreposatory.GetById(id);
            return View(emplo);
        }

        // POST: TeachersController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Teachers collection)
        {
            try
            {
                 teachersreposatory.DeleteById(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
