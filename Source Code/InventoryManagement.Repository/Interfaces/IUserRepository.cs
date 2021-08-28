using InventoryManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManagement.Repository.Interfaces
{
    public interface IUserRepository
    {
        User GetByUserNameAndPassword(string name, string password);
        User GetByUserName(string name);
        User GetById(int id);
        List<User> GetAll();
        bool SaveOrUpdate(User entity);
        bool Delete(User entity);
        List<User> GetByRoleId(int id);
    }

}
