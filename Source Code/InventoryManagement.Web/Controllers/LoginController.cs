using AutoMapper;
using InventoryManagement.Service.Interfaces;
using InventoryManagement.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagement.Web.Controllers
{
    public class LoginController : Controller
    {
        private IUserService _userService;
        private IMapper _mapper;
        public LoginController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            var vm = new LoginViewModel();
            return View(vm);
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel vm)
        {
            try
            {
                //6E475092CB912EA2F9258A1E4433D74D = 123
                var user = _userService.GetByUserName(vm.UserName);
                if (user == null)
                {
                    vm.ErrorMessage = "Invalid user name";
                    return View("Index", vm);
                }

                user = _userService.GetByUserNameAndPassword(vm.UserName, vm.Password);
                if (user == null)
                {
                    vm.ErrorMessage = "Invalid password";
                    return View("Index", vm);
                }

                if (!user.Active)
                {
                    vm.ErrorMessage = "User not activated. Please contact the administrator";
                    return View("Index", vm);
                }

                Context.Context.InitiateSession(user, _mapper);
                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                vm.ErrorMessage = ex.Message;
                return View("Index", vm);
            }

        }
        public IActionResult Logout()
        {
            Context.Context.TerminateSession();
            return RedirectToAction("Index");
        }
    }
}
