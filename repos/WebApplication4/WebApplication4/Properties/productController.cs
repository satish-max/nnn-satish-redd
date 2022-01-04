using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication4.Properties
{
    public class productController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult oneMoreAction()
        {
            return View();

        }
    }
}
