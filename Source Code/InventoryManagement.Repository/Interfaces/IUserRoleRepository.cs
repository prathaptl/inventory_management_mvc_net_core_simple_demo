using InventoryManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManagement.Repository.Interfaces
{
    public interface IUserRoleRepository
    {
        UserRole GetByName(string name);
        UserRole GetById(int id);
        List<UserRole> GetAll();
        bool SaveOrUpdate(UserRole entity);
        bool Delete(UserRole entity);
    }
}
