using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Homer_Full_Version_NET_Core_1_0.Controllers
{
    public class AnalyticsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}