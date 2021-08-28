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
    public class UserRoleController : BaseAuthenticationController
    {
        private IUserRoleService _userRoleService;
        private IMapper _mapper;
        public UserRoleController(IUserRoleService userRoleService, IMapper mapper)
        {
            _userRoleService = userRoleService;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            if (TempData["Error"] != null)
            {
                ViewBag.ErrorMessage = TempData["Error"];
            }
            var vms = _userRoleService.GetAll().Select(x => _mapper.Map<UserRoleListViewModel>(x)).ToList();
            return View(vms);
        }
        public IActionResult Edit(int id = 0)
        {
            var userRole = id == 0 ? new UserRole() : _userRoleService.GetById(id);
            var vm = _mapper.Map<UserRoleViewModel>(userRole);

            //Initialize user role privileges
            vm.InitPrivileges(_userRoleService);
            return View(vm);
        }

        [HttpPost]
        public object Edit(string data)
        {
            try
            {
                var base64EncodedBytes = System.Convert.FromBase64String(data);
                var decodedString = System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
                var vm = JsonConvert.DeserializeObject<UserRoleViewModel>(decodedString);

                //Validate madatory fields
                var validationError = vm.Validate();
                if (!string.IsNullOrEmpty(validationError))
                    throw new Exception(validationError);

                var role = vm.Id == 0 ? new UserRole() : _userRoleService.GetById(vm.Id);
                _mapper.Map(vm, role);

                AddOrUpdateRolePrivileges(vm, role);

                _userRoleService.SaveOrUpdate(role);
                return new { success = true };
            }
            catch (Exception ex)
            {
                return new { success = false, error = ex.Message };
            }
        }
        private static void AddOrUpdateRolePrivileges(UserRoleViewModel vm, UserRole role)
        {
            foreach (var group in vm.PrivilegeGroups)
            {
                foreach (var privilegeVm in group.RolePrivileges)
                {
                    if (privilegeVm.Id == 0)
                    {
                        var privilege = new RolePrivilege() { Name = privilegeVm.Name, Value = privilegeVm.Value };
                        role.Privileges.Add(privilege);
                    }
                    else
                    {
                        var existingPrivilege = role.Privileges.FirstOrDefault(x => x.Id == privilegeVm.Id);
                        if (existingPrivilege != null)
                        {
                            existingPrivilege.Value = privilegeVm.Value;
                        }
                    }
                }
            }
        }
        public IActionResult Delete(int id)
        {
            try
            {
                var user = _userRoleService.GetById(id);
                _userRoleService.Delete(user);

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
