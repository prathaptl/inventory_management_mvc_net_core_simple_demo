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
    public class UserRepository : IUserRepository
    {

        private ApplicationDbContext _db;

        public UserRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool Delete(User entity)
        {
            try
            {
                _db.Users.Remove(entity);
                _db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }

        }

        public List<User> GetAll()
        {
            var users = _db.Users.ToList();
            return users;
        }

        public User GetById(int id)
        {
            var user = _db.Users.Where(x=>x.Id == id).Include(x=>x.Role).FirstOrDefault();
            return user;
        }

        public User GetByName(string name)
        {
            var user = _db.Users.FirstOrDefault(x => x.Name == name);
            return user;
        }

        public bool SaveOrUpdate(User entity)
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

        List<User> IUserRepository.GetByRoleId(int id)
        {
            var user = _db.Users.Where(x => x.RoleId == id).Include(x => x.Role).ToList();
            return user;
        }

        User IUserRepository.GetByUserName(string name)
        {
            var user = _db.Users.FirstOrDefault(x => x.UserName == name);
            return user;
        }

        User IUserRepository.GetByUserNameAndPassword(string name, string password)
        {
            var user = _db.Users.Where(x => x.UserName == name && x.Password == password)
                .Include(x=>x.Role).ThenInclude(x=>x.Privileges).ToList().FirstOrDefault();
            return user;
        }
    }
}
