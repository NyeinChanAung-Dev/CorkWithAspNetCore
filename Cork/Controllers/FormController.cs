using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Cork.Controllers
{
    [Authorize]
    public class FormController : Controller
    {
        public IActionResult BootstrapBasic()
        {
            return View();
        }

        public IActionResult InputGroupBasic()
        {
            return View();
        }

        public IActionResult Layouts()
        {
            return View();
        }

        public IActionResult Validation()
        {
            return View();
        }

        public IActionResult InputMask()
        {
            return View();
        }

        public IActionResult BootstrapSelect()
        {
            return View();
        }

        public IActionResult Select2()
        {
            return View();
        }

        public IActionResult BootstrapTouchspin()
        {
            return View();
        }

        public IActionResult Maxlength()
        {
            return View();
        }

        public IActionResult CheckboxRadio()
        {
            return View();
        }

        public IActionResult Switches()
        {
            return View();
        }

        public IActionResult Wizard()
        {
            return View();
        }

        public IActionResult Fileupload()
        {
            return View();
        }

        public IActionResult QuillEditor()
        {
            return View();
        }

        public IActionResult Markdown()
        {
            return View();
        }

        public IActionResult DateRangePicker()
        {
            return View();
        }

        public IActionResult Clipboard()
        {
            return View();
        }

        public IActionResult Typeahead()
        {
            return View();
        }
    }
}