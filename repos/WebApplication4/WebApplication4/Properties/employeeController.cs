using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication4.Properties
{
    public class employeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public string FirstName()
        {
            return "firstName";
        }
        public string LastName()
        {
            return "lastName";
        }
    }
}
