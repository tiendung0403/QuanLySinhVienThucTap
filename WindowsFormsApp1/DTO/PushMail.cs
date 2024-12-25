using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO
{
    public class PushMail
    {
        public static bool GuiEmail(string toEmail, string subject, string messageBody)
        {
            try
            {
                var fromAddress = new MailAddress("wthe9843@gmail.com", "Hệ thống quản lý");
                var toAddress = new MailAddress(toEmail);
                const string fromPassword = "hmyd shvs kcex vzjt";

                using (var smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtp.EnableSsl = true;
                    smtp.Credentials = new NetworkCredential(fromAddress.Address, fromPassword);

                    using (var message = new MailMessage(fromAddress, toAddress)
                    {
                        Subject = subject,
                        Body = messageBody
                    })
                    {
                        smtp.Send(message);
                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
