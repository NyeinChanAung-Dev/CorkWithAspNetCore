using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Cork.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        public IActionResult UserProfile()
        {
            return View();
        }

        public IActionResult AccountSetting()
        {
            return View();
        }
    }
}