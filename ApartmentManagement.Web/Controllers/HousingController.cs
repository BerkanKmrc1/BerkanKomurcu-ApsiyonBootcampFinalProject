using ApartmentManagement.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApartmentManagement.Web.Controllers
{
    public class HousingController : Controller
    {
        private readonly IHousingService _housingService;
        public HousingController(IHousingService housingService)
        {
            _housingService = housingService;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
