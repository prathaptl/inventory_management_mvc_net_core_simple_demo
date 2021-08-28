using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Text;

namespace InventoryManagement.Domain.Structures
{
    public class SecurityPrivileges
    {
        #region MainMenu
        [Category("Main Menu"), DisplayName("Master Data")]
        public bool MenuMaterData { get; set; }

        [Category("Main Menu"), DisplayName("Inventory")]
        public bool MenuInventory { get; set; }

        [Category("Main Menu"), DisplayName("Administration")]
        public bool MenuAdministration { get; set; }
        #endregion

        #region Product
        [Category("Products"), DisplayName("View Products")]
        public bool ProductIndex { get; set; }

        [Category("Products"), DisplayName("Add Product")]
        public bool ProductAdd { get; set; }

        [Category("Products"), DisplayName("Edit Product")]
        public bool ProductEdit { get; set; }

        [Category("Products"), DisplayName("Delete Product")]
        public bool ProductDelete { get; set; }
        #endregion

        #region User
        [Category("User"), DisplayName("View User")]
        public bool UserIndex { get; set; }

        [Category("User"), DisplayName("Add User")]
        public bool UserAdd { get; set; }

        [Category("User"), DisplayName("Edit User")]
        public bool UserEdit { get; set; }

        [Category("User"), DisplayName("Delete User")]
        public bool UserDelete { get; set; }
        #endregion

        #region User Role
        [Category("User Role"), DisplayName("View User Role")]
        public bool UserRoleIndex { get; set; }

        [Category("User Role"), DisplayName("Add User Role")]
        public bool UserRoleAdd { get; set; }

        [Category("User Role"), DisplayName("Edit User Role")]
        public bool UserRoleEdit { get; set; }

        [Category("User Role"), DisplayName("Delete User Role")]
        public bool UserRoleDelete { get; set; }
        #endregion

        #region Inventory
        [Category("Inventory"), DisplayName("Update Stock")]
        public bool InventoryUpdateStock { get; set; }

        [Category("Inventory"), DisplayName("Email Inventory Summary")]
        public bool EmailSendMerchantSummary { get; set; }
        #endregion

        #region Other

        [Category("Other"), DisplayName("Hangfire Dashboard")]
        public bool Hangfire { get; set; }

        #endregion

        public bool HasPrivilege(string privilegeCode)
        {
            PropertyInfo[] props = typeof(SecurityPrivileges).GetProperties();
            foreach (var p in props)
            {
                if(p.Name == privilegeCode) {
                    return (bool)p.GetValue(this);
                }
            }

            return false;
        }

    }
}
