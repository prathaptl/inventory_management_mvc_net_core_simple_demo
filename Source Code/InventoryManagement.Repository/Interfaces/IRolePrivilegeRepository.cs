using InventoryManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManagement.Repository.Interfaces
{
    interface IRolePrivilegeRepository
    {
        RolePrivilege GetByName(string name);
        RolePrivilege GetById(int id);
        List<RolePrivilege> GetAll();
        bool SaveOrUpdate(RolePrivilege entity);
        bool Delete(RolePrivilege entity);
    }
}
