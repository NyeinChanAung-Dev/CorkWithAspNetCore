using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Cork.Controllers
{
    [Authorize]
    public class DashboardController : Controller
    {
        public IActionResult AnalyticsDashboard()
        {
            return View();
        }

        public IActionResult SalesDashboard()
        {
            return View();
        }
    }
}