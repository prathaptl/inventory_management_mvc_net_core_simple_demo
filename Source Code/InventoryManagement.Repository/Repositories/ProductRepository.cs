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
    public class ProductRepository : IProductRepository
    {
        private ApplicationDbContext _db;

        public ProductRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool Delete(Product entity)
        {
            try
            {
                _db.Products.Remove(entity);
                _db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Product> GetAll()
        {
            var roles = _db.Products.ToList();
            return roles;
        }

        public Product GetById(int id)
        {
            var role = _db.Products.Find(id);
            return role;
        }

        public Product GetByCode(string code)
        {
            var role = _db.Products.FirstOrDefault(x => x.Code == code); ;
            return role;
        }

        public bool SaveOrUpdate(Product entity)
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
