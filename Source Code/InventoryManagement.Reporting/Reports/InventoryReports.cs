using InventoryManagement.Reporting.Interfaces;
using InventoryManagement.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManagement.Reporting.Reports
{
    public class InventoryReports : IInventoryReports
    {
        private IProductRepository _productRepository;

        public InventoryReports(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public string InventorySummary()
        {
            var reportString = @"<table  style='font-family: Arial, Helvetica, sans-serif;border-collapse: collapse;width: 100%;'>
                                  <tr>
                                    <th style='border: 1px solid #ddd;padding: 8px;padding-top: 12px;padding-bottom: 12px;text-align: left;background-color: #04AA6D;color: white;'>Name</th>
                                    <th style='border: 1px solid #ddd;padding: 8px;padding-top: 12px;padding-bottom: 12px;text-align: left;background-color: #04AA6D;color: white;'>Qty</th>
                                  </tr>";

            var products = _productRepository.GetAll();
            foreach (var product in products)
            {
                reportString += string.Format(@"<tr><td style='border: 1px solid #ddd;padding: 8px;'>{0}</td>
                                                    <td style='border: 1px solid #ddd;padding: 8px;'>{1}</td>
                                                  </tr>",product.Name, product.CurrentQty.ToString("N0"));
            }

            reportString += @"</table>";

            return reportString;
        }
    }
}
