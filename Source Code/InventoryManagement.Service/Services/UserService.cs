using InventoryManagement.Domain.Entities;
using InventoryManagement.Repository.Interfaces;
using InventoryManagement.Service.Interfaces;
using InventoryManagement.Utility.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManagement.Service.Services
{
    public class UserService : IUserService
    {
        private IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public bool Delete(User entity)
        {
            return _userRepository.Delete(entity);
        }

        public List<User> GetAll()
        {
            return _userRepository.GetAll();
        }

        public User GetById(int id)
        {
            return _userRepository.GetById(id);
        }

        public User GetByUserName(string name)
        {
            return _userRepository.GetByUserName(name);
        }

        public User GetByUserNameAndPassword(string name, string password)
        {
            var encodedPassword = Utilities.GetEncodedPassword(password);
            return _userRepository.GetByUserNameAndPassword(name, encodedPassword);
        }

        public bool SaveOrUpdate(User entity)
        {
            if (entity.SetPassword)
            {
                var encodedPassword = Utilities.GetEncodedPassword(entity.Password);
                entity.Password = encodedPassword;
            }
            return _userRepository.SaveOrUpdate(entity);
        }
    }
}
