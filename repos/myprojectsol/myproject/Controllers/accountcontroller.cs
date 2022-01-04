using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using myproject.Models;

namespace myprojectsol.Controllers
{
    public class Accountcontroller : Controller
    {
       
        public IActionResult AccountModel()
        {
            AccountModel ac = new AccountModel();
            ac.AccountId = 1;
            ac.AccHolderName = "satish";
            ac.accHolderAddress = "village";
        }
    }
}
