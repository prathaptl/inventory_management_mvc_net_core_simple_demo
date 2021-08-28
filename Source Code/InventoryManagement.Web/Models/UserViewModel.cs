using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagement.Web.Models
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string CurrentPassword { get; set; }
        public string ConfirmPassword { get; set; }
        public bool SetPassword { get; set; }
        public bool Active { get; set; }

        public string Validate()
        {
            var error = "";

            if (string.IsNullOrEmpty(Name))
                error += "\n" + "Name cannot be empty";
            if (string.IsNullOrEmpty(PhoneNo))
                error += "\n" + "Phone number cannot be empty";
            if (string.IsNullOrEmpty(UserName))
                error += "\n" + "User name cannot be empty";
            if (string.IsNullOrEmpty(Email))
                error += "\n" + "Email cannot be empty";

            if (Role == null)
                error += "\n" + "User role not selected";

            if (SetPassword && CurrentPassword != ConfirmPassword)
                error += "\n" + "Password and confirm password did not matched";

            return error;
        }

        public BasicEntityViewModel Role { get; set; }
    }
}
