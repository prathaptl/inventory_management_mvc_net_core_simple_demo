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
    public class ProductController : Controller
    {
        private IProdutService _productService;
        private IMapper _mapper;
        public ProductController(IProdutService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            if (TempData["Error"] != null)
            {
                ViewBag.ErrorMessage = TempData["Error"];
            }
            var vms = _productService.GetAll().Select(x => _mapper.Map<ProductListViewModel>(x)).ToList();
            return View(vms);
        }
        public IActionResult Edit(int id = 0)
        {
            var product = id == 0 ? new Product() : _productService.GetById(id);
            var vm = _mapper.Map<ProductViewModel>(product);
            return View(vm);
        }

        [HttpPost]
        public object Edit(string data)
        {
            try
            {
                var base64EncodedBytes = System.Convert.FromBase64String(data);
                var decodedString = System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
                var vm = JsonConvert.DeserializeObject<ProductViewModel>(decodedString);

                //Validate madatory fields
                var validationError = vm.Validate();
                if (!string.IsNullOrEmpty(validationError))
                    throw new Exception(validationError);

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
        public IActionResult Delete(int id)
        {
            try
            {
                var product = _productService.GetById(id);
                _productService.Delete(product);

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["Error"] = Utility.Common.Utilities.GetExceptionText(ex);
                return RedirectToAction("Index");
            }

        }
    }
}
