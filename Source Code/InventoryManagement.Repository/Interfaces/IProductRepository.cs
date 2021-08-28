using InventoryManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManagement.Repository.Interfaces
{
    public interface IProductRepository
    {
        Product GetByCode(string name);
        Product GetById(int id);
        List<Product> GetAll();
        bool SaveOrUpdate(Product entity);
        bool Delete(Product entity);
    }
}
