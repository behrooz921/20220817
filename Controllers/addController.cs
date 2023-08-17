using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sol01.Controllers
{
    public class addController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("add")]
        public Int16 add(Int16 N1, Int16 N2)
        {
            Int16 result = (short)(N1 + N2);
            return result;
        }
    }
}
