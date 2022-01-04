using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication4.Properties
{
    public class HelloworldController : Controller
    {
        public string Index()
        {
            return "this is the default action";
            
        }
        public string Welcome()
        {
            return "this is welcome action";
        }
    }
}
