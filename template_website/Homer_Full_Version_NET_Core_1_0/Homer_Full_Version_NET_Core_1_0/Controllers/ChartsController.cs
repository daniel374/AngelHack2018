using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Homer_Full_Version_NET_Core_1_0.Controllers
{
    public class ChartsController : Controller
    {

        public IActionResult ChartJs()
        {
            return View();
        }

        public IActionResult FlotCharts()
        {
            return View();
        }

        public IActionResult InlineGraphs()
        {
            return View();
        }

        public IActionResult Chartist()
        {
            return View();
        }

        public IActionResult C3Charts()
        {
            return View();
        }
    }
}