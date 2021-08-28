using InventoryManagement.Data;
using InventoryManagement.Domain.Entities;
using InventoryManagement.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InventoryManagement.Repository.Repositories
{
    public class UserRoleRepository : IUserRoleRepository
    {
        private ApplicationDbContext _db;

        public UserRoleRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool Delete(UserRole entity)
        {
            try
            {
                _db.UserRoles.Remove(entity);
                _db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<UserRole> GetAll()
        {
            var roles = _db.UserRoles.ToList();
            return roles;
        }

        public UserRole GetById(int id)
        {
            var role = _db.UserRoles.Where(x => x.Id == id).Include(x => x.Privileges).ToList().FirstOrDefault();
            return role;
        }

        public UserRole GetByName(string name)
        {
            var role = _db.UserRoles.Where(x => x.Name == name).Include(x => x.Privileges).ToList().FirstOrDefault();
            return role;
        }

        public bool SaveOrUpdate(UserRole entity)
        {
            try
            {
                _db.Entry(entity).State = entity.Id == 0 ? EntityState.Added : EntityState.Modified;
                _db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
