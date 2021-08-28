using InventoryManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManagement.Service.Interfaces
{
    public interface IUserRoleService
    {
        UserRole GetByName(string name);
        UserRole GetById(int id);
        List<UserRole> GetAll();
        bool SaveOrUpdate(UserRole entity);
        bool Delete(UserRole entity);
    }
}
