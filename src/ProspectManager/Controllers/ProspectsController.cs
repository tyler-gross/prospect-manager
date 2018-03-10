using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.Net;
using System.Data.Entity.Infrastructure;
using ProspectManager.Data;
using ProspectManager.ViewModels;

namespace ProspectManager.Controllers
{
    public class ProspectsController : BaseController
    {
        private ProspectsRepository _prospectsRepository = null;
        private CollegesRepository _collegesRepository = null;

        public ProspectsController()
        {
            _prospectsRepository = new ProspectsRepository(Context);
            _collegesRepository = new CollegesRepository(Context);
        }

        public ActionResult Index()
        {
            var prospects = _prospectsRepository.GetList();

            return View(prospects);
        }

        public ActionResult Add()
        {
            var viewModel = new ProspectsAddViewModel();

            viewModel.Init(Repository, _collegesRepository);

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Add(ProspectsAddViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var prospect = viewModel.Prospect;

                _prospectsRepository.Add(prospect);

                TempData["Message"] = "Your prospect was successfully added!";

                return RedirectToAction("index");
            }

            viewModel.Init(Repository, _collegesRepository);

            return View(viewModel);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var prospect = _prospectsRepository.Get((int)id);

            if (prospect == null)
            {
                return HttpNotFound();
            }

            var viewModel = new ProspectsEditViewModel()
            {
                Prospect = prospect
            };
            viewModel.Init(Repository, _collegesRepository);

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Edit(ProspectsEditViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var prospect = viewModel.Prospect;

                _prospectsRepository.Update(prospect);

                TempData["Message"] = "Your prospect was successfully updated!";

                return RedirectToAction("index");
            }

            viewModel.Init(Repository, _collegesRepository);

            return View(viewModel);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var prospect = _prospectsRepository.Get((int)id);

            if (prospect == null)
            {
                return HttpNotFound();
            }

            return View(prospect);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            _prospectsRepository.Delete(id);

            TempData["Message"] = "Your prospect was successfully deleted!";

            return RedirectToAction("index");
        }
    }
}