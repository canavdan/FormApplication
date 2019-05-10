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
    public class UserController : Controller
    {
        private IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        // GET: User
        public ActionResult Index()
        {
            var model = new UserListViewModel
            {
                Users = _userService.GetAll()
            };
            return View();
        }

        public ActionResult Register()
        {
            User model = new User();
            return View(model);
        }

        [HttpPost]
        public ActionResult Register(User user )
        {
            if (ModelState.IsValid)
            {
                _userService.Add(user);
                TempData.Add("message", "Kullanıcı başarıyla eklendi");

            }
           
            return RedirectToAction("Index");
        }
    }
}