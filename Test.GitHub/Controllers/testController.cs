using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Test.GitHub.Controllers
{
    public class testController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult test123()
        {
            return View();
        }
    }
}