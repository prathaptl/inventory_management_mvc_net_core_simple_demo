using InventoryManagement.Service.Interfaces;
using Microsoft.Extensions.Configuration;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Service.Services
{
    public class SendGridEmailService : IEmailService
    {
        private IConfiguration _configuration;

        public SendGridEmailService(IConfiguration configuration)
        {
            _configuration = configuration;
        }   
        public async Task SendEmailAsync(string recipient, string subject, string body)
        {
            var apiKey = _configuration["SendGridAPIKey"];
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress("prathaptl@gmail.com", "Prathap Liyanarachchi");
            var to = new EmailAddress(recipient, "Recipient");
            var plainTextContent = body;
            var htmlContent = body;
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = await client.SendEmailAsync(msg);

            if (!response.IsSuccessStatusCode)
                throw new Exception("Failed to send email. " + response.Body);
        }
    }
}
