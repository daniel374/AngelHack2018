using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Homer_Seed_Project_NET_Core_1_0.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
