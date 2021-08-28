using AutoMapper;
using InventoryManagement.Domain.Entities;
using InventoryManagement.Service.Interfaces;
using InventoryManagement.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagement.Web.Controllers
{
    public class UserController : BaseAuthenticationController
    {
        private IUserService _userService;
        private IUserRoleService _userRoleService;
        private IMapper _mapper;
        public UserController(IUserService userService, IMapper mapper, IUserRoleService userRoleService)
        {
            _userService = userService;
            _mapper = mapper;
            _userRoleService = userRoleService;
        }
        public IActionResult Index()
        {
            if (TempData["Error"] != null)
            {
                ViewBag.ErrorMessage = TempData["Error"];
            }
            var usersVms = _userService.GetAll().Select(x => _mapper.Map<UserListViewModel>(x)).ToList();
            return View(usersVms);
        }

        public IActionResult Edit(int id)
        {
            var user = id == 0 ? new User() : _userService.GetById(id);
            var vm = _mapper.Map<UserViewModel>(user);
            return View(vm);
        }

        [HttpPost]
        public object Edit(string data)
        {
            try
            {
                var base64EncodedBytes = System.Convert.FromBase64String(data);
                var decodedString = System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
                var vm = JsonConvert.DeserializeObject<UserViewModel>(decodedString);

                //Validate madatory fields
                var validationError = vm.Validate();
                if (!string.IsNullOrEmpty(validationError))
                    throw new Exception(validationError);

                var user = vm.Id == 0 ? new User() : _userService.GetById(vm.Id);
                _mapper.Map(vm, user);

                if (vm.SetPassword && vm.CurrentPassword != vm.ConfirmPassword)
                {
                    user.Password = vm.CurrentPassword;
                }

                    if (vm.Role == null)
                {
                    var userRole = _userRoleService.GetById(vm.Role.Id);
                    user.Role = userRole;
                }

                _userService.SaveOrUpdate(user);
                return new { success = true };
            }
            catch (Exception ex)
            {
                return new { success = false, error = ex.Message };
            }
        }
        public object GetUserRoles()
        {
            var roles = _userRoleService.GetAll();
            return roles.Select(x => new { Id = x.Id, Name = x.Name }).ToList();
        }
        public IActionResult Delete(int id)
        {
            try
            {
                var user = _userService.GetById(id);
                _userService.Delete(user);

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["Error"] = Utility.Common.Utilities.GetExceptionText(ex);
                return RedirectToAction("Index");
            }

        }
    }
}
