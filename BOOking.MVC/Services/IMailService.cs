using BOOking.MVC.Data;

namespace BOOking.MVC.Services
{
    public interface IMailService
    {
        Task SendEmailAsync(RequestEmail requestEmail);
    }
}
