using InventoryManagement.Domain.Entities;
using InventoryManagement.Repository.Interfaces;
using InventoryManagement.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManagement.Service.Services
{
    public class ProductService : IProdutService
    {
        private IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public bool Delete(Product entity)
        {
            return _productRepository.Delete(entity);
        }

        public List<Product> GetAll()
        {
            return _productRepository.GetAll();
        }

        public Product GetByCode(string code)
        {
            return _productRepository.GetByCode(code);
        }

        public Product GetById(int id)
        {
            return _productRepository.GetById(id);
        }

        public bool SaveOrUpdate(Product entity)
        {
            return _productRepository.SaveOrUpdate(entity);
        }
    }
}
