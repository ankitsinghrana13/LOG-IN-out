using LOG_IN_out.Repository.Interface;
using LOG_IN_out.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LOG_IN_out.Controllers
{
    public class AccountController : Controller
    {
        private IUsers UserServices;
        public AccountController(IUsers users)
        {
            UserServices = users;
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(SignInModel model)
        {
            if (ModelState.IsValid)
            {
                var result = UserServices.SignIn(model);
            }
         


            return View(result);
        }
    }
}
