using FormApplication.Business.Abstract;
using FormApplication.Entities.Concrete;
using FormApplication.MvcWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormApplication.MvcWeb.Controllers
{
    [Authorize]
    public class FormController : Controller
    {
        private IFormService _formService;

        public FormController(IFormService formService)
        {
            _formService = formService;
        }
        [Authorize]
        [HttpGet]
        public ActionResult Index()
        {

            var model = new FormDetailViewModel
            {
                FormDetail = _formService.GetFormDetail()
            };
            return View(model);
        }

        [Authorize]
        [HttpGet]
        public ActionResult GetAll()
        {

            var model = new FormDetailViewModel
            {
                FormDetail = _formService.GetFormDetail()
            };
            return View(model);
        }
        [Authorize]
        public ActionResult GetFormById(int formID)
        {

            var model = new SingleFormDetail
            {
                SingleForm = _formService.GetById(formID)
            };
            return View(model);
        }

        public ActionResult Add()
        {
            var model = new FormAddViewModel
            {
                Form = new Form(),          
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult Add(Form form)
        {
            if (ModelState.IsValid)
            {
                _formService.Add(form);
                TempData.Add("message", "Form başarıyla eklendi");

            }
            return RedirectToAction("Add");
        }

        public ActionResult Update(int formId)
        {
            var model = new FormUpdateViewModel
            {
               form = _formService.GetById(formId),
               
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult Update(Form form)
        {
            if (ModelState.IsValid)
            {
                _formService.Update(form);
                TempData.Add("message", "Form Başarıyla Güncellendi");

            }
            return RedirectToAction("Update");
        }

        public ActionResult Delete(Form form)
        {
       
            _formService.Delete(form);
            TempData.Add("message", "Form Başarıyla Silindi");
            return RedirectToAction("Index");
        }
    }
}