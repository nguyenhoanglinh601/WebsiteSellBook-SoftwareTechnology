using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace WebsiteBanSach.Controllers
{
    public class Debug : Controller
    {
        public IActionResult debug()
        {
            //ViewData["name"] = Request.Cookies.FirstOrDefault(i => i.Key=="name").Value;
            ViewData["id"] = HttpContext.Session.GetString("id");
            return View();
        }
    }
}
