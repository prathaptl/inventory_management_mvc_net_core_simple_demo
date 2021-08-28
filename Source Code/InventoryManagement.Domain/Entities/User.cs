using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace InventoryManagement.Domain.Entities
{
    [Table("users")]
    public class User : EntityBase
    {
        public string Name { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool Active { get; set; }

        [NotMapped]
        public bool SetPassword { get; set; }

        [ForeignKey("Role")]
        public int RoleId { get; set; }
        public virtual UserRole Role { get; set; }
    }
}
