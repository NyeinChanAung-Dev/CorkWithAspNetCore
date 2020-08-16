using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Cork.Controllers
{
    [Authorize]
    public class DataTableController : Controller
    {
        public IActionResult TbBasic()
        {
            return View();
        }

        public IActionResult DtBasic()
        {
            return View();
        }

        public IActionResult DtBasicDark()
        {
            return View();
        }

        public IActionResult DtOrderingSorting()
        {
            return View();
        }

        public IActionResult DtMultiColumnOrdering()
        {
            return View();
        }

        public IActionResult DtMultipleTables()
        {
            return View();
        }

        public IActionResult DtAlternativePagination()
        {
            return View();
        }

        public IActionResult DtCustom()
        {
            return View();
        }

        public IActionResult DtRangeSearch()
        {
            return View();
        }

        public IActionResult DtHtml5()
        {
            return View();
        }

        public IActionResult DtLiveDomOrdering()
        {
            return View();
        }

        public IActionResult DtMiscellaneous()
        {
            return View();
        }
    }
}