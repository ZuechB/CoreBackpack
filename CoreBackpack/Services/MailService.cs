using CoreBackpack.Models;
using SendGrid;
using SendGrid.Helpers.Mail;
using System.Threading.Tasks;

namespace CoreBackpack.Services
{
    public interface IMailService
    {
        Task<Response> Send(Email email);
    }

    public class MailService : IMailService
    {
        public async Task<Response> Send(Email email)
        {
            var client = new SendGridClient(email.ApiKey);

            var from = new EmailAddress(email.From.Email, email.From.Name);
            var msg = MailHelper.CreateSingleTemplateEmail(from,
                                                          email.To,
                                                          email.TemplateId,
                                                          email.Substitutions
                                                        );

            var response = await client.SendEmailAsync(msg);

            return response;
        }
    }
}
