using InventoryManagement.Domain.Entities;
using InventoryManagement.Domain.Structures;
using InventoryManagement.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace InventoryManagement.Web.Models
{
    public class UserRoleViewModel
    {

        public UserRoleViewModel()
        {
            PrivilegeGroups = new List<RolePrivilegeGroupViewModel>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsSuperUser { get; set; }

        public List<RolePrivilegeGroupViewModel> PrivilegeGroups { get; set; }

        public string Validate()
        {
            var error = "";

            if (string.IsNullOrEmpty(Name))
                error += "\n" + "Name cannot be empty";

            return error;
        }
        public void InitPrivileges(IUserRoleService userRoleService)
        {
            var privileges = new List<RolePrivilegeViewModel>();

            PropertyInfo[] props = typeof(SecurityPrivileges).GetProperties();
            var propNames = props.Select(x => x.Name);
            var existingPrivileges = Id == 0 ? new List<RolePrivilege>() : userRoleService.GetById(Id).Privileges;
            foreach (var item in existingPrivileges)
            {
                var privVm = new RolePrivilegeViewModel();
                privVm.Id = item.Id;
                privVm.Name = item.Name;
                privVm.Value = item.Value;

                if (propNames.Contains(item.Name))
                    privileges.Add(privVm);
            }


            foreach (var p in props)
            {

                //var privAttr = (PrivilegeAttribute) p.GetCustomAttributes(typeof (PrivilegeAttribute), false).First();
                var categoryAttr = (CategoryAttribute)p.GetCustomAttributes(typeof(CategoryAttribute), false).First();
                var displayNameAttr = (DisplayNameAttribute)p.GetCustomAttributes(typeof(DisplayNameAttribute), false).First();

                var privVm = new RolePrivilegeViewModel { Name = p.Name, DisplayName = displayNameAttr.DisplayName, Value = false, Category = categoryAttr.Category };
                var existingPrivVm = privileges.FirstOrDefault(x => x.Name == privVm.Name);
                if (existingPrivVm != null)
                {
                    existingPrivVm.DisplayName = privVm.DisplayName;
                    existingPrivVm.Category = privVm.Category;
                }
                else
                {
                    privileges.Add(privVm);
                }
            }

            var categoryDict = new Dictionary<string, List<RolePrivilegeViewModel>>();

            foreach (var item in privileges)
            {
                if (!categoryDict.ContainsKey(item.Category))
                {
                    categoryDict.Add(item.Category, new List<RolePrivilegeViewModel> { item });
                }
                else
                {
                    categoryDict[item.Category].Add(item);
                }
            }

            foreach (var key in categoryDict.Keys)
            {
                var privCat = new RolePrivilegeGroupViewModel() { Name = key, RolePrivileges = categoryDict[key] };
                PrivilegeGroups.Add(privCat);
            }

            PrivilegeGroups = PrivilegeGroups.OrderBy(x => x.Name).ToList();
        }
    }

    public class RolePrivilegeViewModel
    {
        public int Id { get; set; }

        public string DisplayName { get; set; }
        public string Name { get; set; }
        public bool Value { get; set; }

        public string Category { get; set; }
    }

    public class RolePrivilegeGroupViewModel
    {
        public string Name { get; set; }

        public List<RolePrivilegeViewModel> RolePrivileges { get; set; }
    }
}
