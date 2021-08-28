using InventoryManagement.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagement.Web.Controllers
{
    public class HomeController : BaseAuthenticationController
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AuthenticationError(string error)
        {
            ViewBag.Error = error;
            return View();
        }
    }
}
