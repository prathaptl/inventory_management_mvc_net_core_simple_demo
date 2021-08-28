using InventoryManagement.Domain.Entities;
using InventoryManagement.Repository.Interfaces;
using InventoryManagement.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManagement.Service.Services
{
    public class UserRoleService : IUserRoleService
    {
        private IUserRoleRepository _userRoleRepository;
        private IUserRepository _userRepository;
        public UserRoleService(IUserRoleRepository userRoleRepository, IUserRepository userRepository)
        {
            _userRoleRepository = userRoleRepository;
            _userRepository = userRepository;
        }

        public bool Delete(UserRole entity)
        {
            var users = _userRepository.GetByRoleId(entity.Id);
            if (users.Count > 0)
                throw new Exception("Failed to delete use role. There are assigned users.");

            return _userRoleRepository.Delete(entity);
        }

        public List<UserRole> GetAll()
        {
            return _userRoleRepository.GetAll();
        }

        public UserRole GetById(int id)
        {
            return _userRoleRepository.GetById(id);
        }

        public UserRole GetByName(string name)
        {
            return _userRoleRepository.GetByName(name);
        }

        public bool SaveOrUpdate(UserRole entity)
        {
            return _userRoleRepository.SaveOrUpdate(entity);
        }
    }
}
