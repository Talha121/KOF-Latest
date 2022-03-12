using KOF.Context;
using KOF.Models;
using KOF.Models.Email;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Options;
using MimeKit;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace KOF.Services.EmailService
{
    public class EmailService : IEmailService
    {
        private readonly EmailSettings _mailSettings;
        private readonly ApplicationDbContext _context;
        public EmailService(IOptions<EmailSettings> mailSettings, ApplicationDbContext context)
        {
            _mailSettings = mailSettings.Value;
            _context = context;
        }
        public async Task SendEmailAsync(EmailInfo emailInfo)
        {
            try
            {
                var email = new MimeMessage();
                email.Sender = MailboxAddress.Parse(_mailSettings.EMail);
                email.To.Add(MailboxAddress.Parse(emailInfo.EmailTo));
                email.Subject = emailInfo.Subject;
                var builder = new BodyBuilder();
                if (emailInfo.Attachments != null)
                {
                    byte[] fileBytes;
                    foreach (var file in emailInfo.Attachments)
                    {
                        if (file.Length > 0)
                        {
                            using (var ms = new MemoryStream())
                            {
                                file.CopyTo(ms);
                                fileBytes = ms.ToArray();
                            }
                            builder.Attachments.Add(file.FileName, fileBytes, ContentType.Parse(file.ContentType));
                        }
                    }
                }
                builder.HtmlBody = emailInfo.Body;
                email.Body = builder.ToMessageBody();
                using var smtp = new SmtpClient();
                smtp.Connect(_mailSettings.Host, _mailSettings.Port, SecureSocketOptions.StartTls);
                smtp.Authenticate(_mailSettings.EMail, _mailSettings.Password);
                await smtp.SendAsync(email);
                smtp.Disconnect(true);
            }
            catch (Exception ex)
            {
                var me = ex.Message;
                throw;
            }

        }

        public async Task SendEmailTemplateAsync(EmailSource emailSource, IEnumerable<Cart> items, Order order)
        {
            
            string header = @"
                            <html>
                                <head>
                                    <title></title>    
                                    <style>table {font-family:arial,sans-serif;border-collapse:collapse;width:100%;}td,th{border:1px solid #dddddd;text-align:left;padding:8px;}tr:nth-child(even){background-color:#dddddd;}
                                    </style></head><body> Order No#"+order.OrderNumber+ @"<br> Order Note:"+ order.Order_Notes + @"
                                 <table><tr><th>Item</th><th>Quntity</th><th>Amount</th></tr>";
         
            var footer = 
                         @"<tr><th>Delivery Charges</th><th></th><th>" + order.DeliveryCharges + @"</th></tr>"+
                          @"<tr><th> Total</th><th>" + items.Sum(x => x.Quantity) + @"</th><th>" + (items.Sum(x => x.TotalPrice)+ order.DeliveryCharges) + @"</th></tr>"

+ @"</table><br>Delivery Information: <br> Order Person Name:" + order.Name + @"<br> StreatAddress:" + order.order_streataddress +@"<br>House No: "+order.HouseNo+ @"<br>City:" + order.Order_city + @"<br> Contact No:" + order.Order_phoneno + @" </body></html>";

            var bb = "";
            var bodydata = new List<string>();    
            foreach (var item in items)
            {
                var productname = _context.Products.Where(x => x.Id == item.ProductId).SingleOrDefault().Name;
                 bb = @"<tr><th>"+productname+"("+item.unit+")"+"</th><th>"+item.Quantity+"</th><th>(" + item.Quantity +"x"+ item.PerUnitPrice+ ")="+ item.PerUnitPrice*item.Quantity +"</th></tr>";

                bodydata.Add(bb);
            }
            var bo = String.Join(String.Empty, bodydata.ToArray());
            var mailbody = header +bo + footer;
            try
            {

                var email = new MimeMessage();
                email.Sender = MailboxAddress.Parse(_mailSettings.EMail);
                email.To.Add(MailboxAddress.Parse(emailSource.EmailTo));
                email.Subject = $"Welcome {emailSource.UserName}";
                var builder = new BodyBuilder();
                builder.HtmlBody = mailbody;
                email.Body = builder.ToMessageBody();
                using var smtp = new SmtpClient();
                smtp.Connect(_mailSettings.Host, _mailSettings.Port, SecureSocketOptions.StartTls);
                smtp.Authenticate(_mailSettings.EMail, _mailSettings.Password);
                await smtp.SendAsync(email);
                smtp.Disconnect(true);
            }
            catch (Exception ex)
            {
                var ff = ex.Message;

                throw;
            }
         
        }
    }
}
