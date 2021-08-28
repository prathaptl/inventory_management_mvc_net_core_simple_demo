using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace InventoryManagement.Domain.Entities
{
    [Table("role_privileges")]
    public class RolePrivilege : EntityBase
    {
        public string Name { get; set; }
        public bool Value { get; set; }

        [ForeignKey("Role")]
        public int RoleId { get; set; }
        public virtual UserRole Role { get; set; }
    }
}
