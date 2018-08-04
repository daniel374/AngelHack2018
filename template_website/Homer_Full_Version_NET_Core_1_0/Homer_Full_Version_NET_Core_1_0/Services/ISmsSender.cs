using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Homer_Full_Version_NET_Core_1_0.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}
