using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.reposatry;

namespace WebApplication1.Controllers
{
    public class StudentControllercs : Controller
    {
        private  StudentReposatory Studentreposatory;
        public StudentControllercs()
        {

            Studentreposatory = new StudentReposatory();
        }
        // GET: StudentControllercs
        public ActionResult Index1()
        {
            var std = Studentreposatory.GetAllStudent();
            return View(std);
        }

        // GET: StudentControllercs/Details/5
        public ActionResult Details(int id)
        {
            var std = Studentreposatory.GetById(id);
            return View(id);
        }

        // GET: StudentControllercs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentControllercs/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Student collection)
        {
            try
            {
                Studentreposatory.InsertStudent(collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentControllercs/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StudentControllercs/Edit/5
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

        // GET: StudentControllercs/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StudentControllercs/Delete/5
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
