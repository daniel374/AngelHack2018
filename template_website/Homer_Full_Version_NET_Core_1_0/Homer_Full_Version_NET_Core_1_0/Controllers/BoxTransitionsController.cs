using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Homer_Full_Version_NET_Core_1_0.Controllers
{
    public class BoxTransitionsController : Controller
    {

        public IActionResult Overview()
        {
            return View();
        }

        public IActionResult ColumnsFromUp()
        {
            return View();
        }

        public IActionResult ColumnsCustom()
        {
            return View();
        }

        public IActionResult PanelsZoom()
        {
            return View();
        }

        public IActionResult RowsFromDown()
        {
            return View();
        }

        public IActionResult RowsFromRight()
        {
            return View();
        }
    }
}