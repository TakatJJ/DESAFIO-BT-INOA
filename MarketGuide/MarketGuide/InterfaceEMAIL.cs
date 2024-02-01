using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketGuide
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message, string ativo);
    }
}
