using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace InventoryManagement.Domain.Entities
{
    [Table("user_roles")]
    public class UserRole : EntityBase
    {
        public UserRole()
        {
            Privileges = new List<RolePrivilege>();
        }
        public string Name { get; set; }
        public bool IsSuperUser { get; set; }
        public List<RolePrivilege> Privileges { get; set; }
    }
}
