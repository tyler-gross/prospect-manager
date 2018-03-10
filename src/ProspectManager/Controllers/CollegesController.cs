using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProspectManager.Data;
using ProspectManager.Models;

namespace ProspectManager.Controllers
{
    public class CollegesController : BaseController
    {
        private CollegesRepository _collegesRepository = null;

        public CollegesController()
        {
            _collegesRepository = new CollegesRepository(Context);
        }

        public ActionResult Index()
        {
            var colleges = _collegesRepository.GetList();

            return View(colleges);
        }

        public ActionResult Add()
        {
            var college = new College();

            return View(college);
        }

        [HttpPost]
        public ActionResult Add(College college)
        {
            ValidateCollege(college);

            if (ModelState.IsValid)
            {
                _collegesRepository.Add(college);

                TempData["Message"] = "Your college was successfully added!";

                return RedirectToAction("index");
            }

            return View(college);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var college = _collegesRepository.Get((int)id);

            if (college == null)
            {
                return HttpNotFound();
            }

            return View(college);
        }

        [HttpPost]
        public ActionResult Edit(College college)
        {
            ValidateCollege(college);

            if (ModelState.IsValid)
            {
                _collegesRepository.Update(college);

                TempData["Message"] = "Your college was successfully updated!";

                return RedirectToAction("index");
            }

            return View(college);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var college = _collegesRepository.Get((int)id);

            if (college == null)
            {
                return HttpNotFound();
            }

            return View(college);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            _collegesRepository.Delete(id);

            TempData["Message"] = "Your college was successfully deleted!";

            return RedirectToAction("index");
        }

        private void ValidateCollege(College college)
        {
            // check for field validation errors
            if (ModelState.IsValidField("collegeName"))
            {
                // collegeName must be unique
                if (_collegesRepository.CollegeHasName(college.Id, college.CollegeName))
                {
                    ModelState.AddModelError("collegeName",
                        "The provided college name is already in use.");
                }
            }
        }
    }
}