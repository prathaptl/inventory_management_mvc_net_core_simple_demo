using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagement.Web.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult Index()
        {
            var errorDetails = HttpContext.Features.Get<IExceptionHandlerPathFeature>();
            ViewBag.ExceptionPath = errorDetails.Path;
            ViewBag.ExceptionMessage = errorDetails.Error.Message;
            ViewBag.StackTrace = errorDetails.Error.StackTrace;

            return View();
        }
    }
}
