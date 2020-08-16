using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Cork.Controllers
{
    [Authorize]
    public class ComponentsController : Controller
    {
        public IActionResult Tabs()
        {
            return View();
        }

        public IActionResult Accordion()
        {
            return View();
        }

        public IActionResult Modal()
        {
            return View();
        }

        public IActionResult Cards()
        {
            return View();
        }

        public IActionResult Carousel()
        {
            return View();
        }

        public IActionResult Blockui()
        {
            return View();
        }

        public IActionResult Countdown()
        {
            return View();
        }

        public IActionResult Counter()
        {
            return View();
        }

        public IActionResult Sweetalert()
        {
            return View();
        }

        public IActionResult Timeline()
        {
            return View();
        }

        public IActionResult SnackbarNoti()
        {
            return View();
        }

        public IActionResult MediaObject()
        {
            return View();
        }

        public IActionResult Listgroup()
        {
            return View();
        }

        public IActionResult Pricingtable()
        {
            return View();
        }

        public IActionResult Lightbox()
        {
            return View();
        }

        public IActionResult DragnDrop()
        {
            return View();
        }

        public IActionResult MapJvector()
        {
            return View();
        }

        public IActionResult ChartsApex()
        {
            return View();
        }
    }
}