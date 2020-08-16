using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Cork.Controllers
{
    [Authorize]
    public class ElementsController : Controller
    {
        public IActionResult Alerts()
        {
            return View();
        }

        public IActionResult Avatar()
        {
            return View();
        }

        public IActionResult Badges()
        {
            return View();
        }

        public IActionResult Breadcrumbs()
        {
            return View();
        }

        public IActionResult Buttons()
        {
            return View();
        }

        public IActionResult Buttonsgroup()
        {
            return View();
        }

        public IActionResult Colorlibrary()
        {
            return View();
        }

        public IActionResult Dropdown()
        {
            return View();
        }

        public IActionResult Infobox()
        {
            return View();
        }

        public IActionResult Jumbotron()
        {
            return View();
        }

        public IActionResult Loader()
        {
            return View();
        }

        public IActionResult Pagination()
        {
            return View();
        }

        public IActionResult Popovers()
        {
            return View();
        }

        public IActionResult Progressbar()
        {
            return View();
        }

        public IActionResult Search()
        {
            return View();
        }

        public IActionResult Tooltips()
        {
            return View();
        }

        public IActionResult Treeview()
        {
            return View();
        }

        public IActionResult Typography()
        {
            return View();
        }

        public IActionResult Fonticons()
        {
            return View();
        }

        public IActionResult Widgets()
        {
            return View();
        }
    }
}