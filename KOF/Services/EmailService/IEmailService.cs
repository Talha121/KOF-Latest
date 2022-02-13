using KOF.Models.Email;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KOF.Services.EmailService
{
   public interface IEmailService
    {
        Task SendEmailAsync(EmailInfo emailInfo);
        Task SendEmailTemplateAsync(EmailSource emailSource);
    }
}
