using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.reposatry;

namespace WebApplication1.Controllers
{
    public class KKStudentsController : Controller
    {
        private KKStudentsReposatory kkstudentreposatory;
        public KKStudentsController()
        {
            kkstudentreposatory = new KKStudentsReposatory();
        }
        // GET: KKStudentsController
        public ActionResult Index()
        {
            var kk = kkstudentreposatory.GetKKStudents();
            return View(kk);
        }

        // GET: KKStudentsController/Details/5
        public ActionResult Details(int id)
        {
          var kks=  kkstudentreposatory.GetById(id);
            return View(kks);
        }

        // GET: KKStudentsController/Create
        public ActionResult Create()
        {
   
            return View();
        }

        // POST: KKStudentsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(KKStudents collection)
        {
            kkstudentreposatory.InsertKKStudent(collection);
            try
            {
                kkstudentreposatory.InsertKKStudent(collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: KKStudentsController/Edit/5
        public ActionResult Edit(int id)
        {
          var stu=  kkstudentreposatory.GetById(id);
            return View(stu);
        }

        // POST: KKStudentsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, KKStudents collection)
        {
            try
            {
                kkstudentreposatory.UpdateKKStudent(id, collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: KKStudentsController/Delete/5
        public ActionResult Delete(int id)
        {
        var ss=    kkstudentreposatory.GetById(id);
            return View(ss);
        }

        // POST: KKStudentsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, KKStudents collection)
        {
            try
            {
                kkstudentreposatory.DeleteKKStudent(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
