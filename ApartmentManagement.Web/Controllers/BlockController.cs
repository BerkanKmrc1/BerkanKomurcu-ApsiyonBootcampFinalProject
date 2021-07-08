using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApartmentManagement.Web.Controllers
{
    public class BlockController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
