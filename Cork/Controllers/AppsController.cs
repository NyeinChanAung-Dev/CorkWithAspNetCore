using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Cork.Controllers
{
    [Authorize]
    public class AppsController : Controller
    {
        public IActionResult Chat()
        {
            return View();
        }

        public IActionResult Mailbox()
        {
            return View();
        }

        public IActionResult TodoList()
        {
            return View();
        }

        public IActionResult Notes()
        {
            return View();
        }

        public IActionResult Scrumboard()
        {
            return View();
        }

        public IActionResult Contacts()
        {
            return View();
        }

        public IActionResult Invoice()
        {
            return View();
        }

        public IActionResult Calendar()
        {
            return View();
        }
    }
}