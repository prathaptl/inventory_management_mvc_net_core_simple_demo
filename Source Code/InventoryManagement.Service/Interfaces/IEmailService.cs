using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Service.Interfaces
{
    public interface IEmailService
    {
        Task SendEmailAsync(string recipient, string subject, string body);
    }
}
