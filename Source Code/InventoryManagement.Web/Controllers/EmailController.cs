using Hangfire;
using InventoryManagement.Reporting.Interfaces;
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
    public class EmailController : Controller
    {
        private IEmailService _emailService;
        private IInventoryReports _inventoryReports;

        public EmailController(IEmailService emailService, IInventoryReports inventoryReports)
        {
            _emailService = emailService;
            _inventoryReports = inventoryReports;
        }

        public IActionResult SendMerchantSummary()
        {
            var vm = new MerchantSummaryViewModel();
            return View(vm);
        }

        [HttpPost]
        public object SendMerchantSummary(string data)
        {
            try
            {
                var base64EncodedBytes = System.Convert.FromBase64String(data);
                var decodedString = System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
                var vm = JsonConvert.DeserializeObject<MerchantSummaryViewModel>(decodedString);

                var emails = vm.Emails.Split(",").ToList();
                var summaryReport = _inventoryReports.InventorySummary();

                foreach (var email in emails)
                {
                    BackgroundJob.Enqueue(() => _emailService.SendEmailAsync(email.Trim(), "Inventory Summary - " + DateTime.Today.ToString("dd-MM-yyyy"), summaryReport));
                }

                return new { success = true };
            }
            catch (Exception ex)
            {
                return new { success = false, error = ex.Message };
            }
        }
    }
}
