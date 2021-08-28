using AutoMapper;
using InventoryManagement.Domain.Entities;
using InventoryManagement.Service.Interfaces;
using InventoryManagement.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagement.Web.Controllers
{
    public class InventoryController : Controller
    {
        private IProdutService _productService;
        private IMapper _mapper;
        public InventoryController(IProdutService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }
        public IActionResult UpdateStock()
        {
            var vm = new ProductViewModel();
            return View(vm);
        }

        [HttpPost]
        public object UpdateStock(string data)
        {
            try
            {
                var base64EncodedBytes = System.Convert.FromBase64String(data);
                var decodedString = System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
                var vm = JsonConvert.DeserializeObject<ProductViewModel>(decodedString);

                var product = vm.Id == 0 ? new Product() : _productService.GetById(vm.Id);
                _mapper.Map(vm, product);

                _productService.SaveOrUpdate(product);
                return new { success = true };
            }
            catch (Exception ex)
            {
                return new { success = false, error = ex.Message };
            }
        }
        public object GetProducts()
        {
            var products = _productService.GetAll();
            return products.Select(x => new { Id = x.Id, Name = x.Code + " - " + x.Name }).ToList();
        }
        public object GetProductById(int id = 0)
        {
            var product = _productService.GetById(id);
            if (product != null)
                return new { Id = product.Id, Code = product.Code, Name = product.Name, CurrentQty = product.CurrentQty, Price = product.Price };
            else
                return new { };
        }
    }
}
