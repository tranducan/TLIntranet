using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TechLinkIntranet.Controllers
{
    public class MQCController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}