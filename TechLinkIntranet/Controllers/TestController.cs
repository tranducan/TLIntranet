using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechLinkIntranet.Models.Test;

namespace TechLinkIntranet.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Table()
        {
            List<TableItems> tableItems = new List<TableItems> { new TableItems
            {
                Name ="Tran Duc An",
                Position ="Staff",
                Address ="Dictrist 4",
                PhoneNumber ="093"
            }
              
            };
            tableItems.Add(new TableItems
            {
                Name = "Luu Hong THanh",
                Position = "Staff",
                Address = "Dictrist 4",
                PhoneNumber = "093"
            });
            tableItems.Add(new TableItems
            {
                Name = "Luu Ha Thu",
                Position = "Staff",
                Address = "Dictrist 4",
                PhoneNumber = "093"
            });



            return View(tableItems);
        }
    }
}