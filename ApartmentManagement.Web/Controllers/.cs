
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApartmentManagement.Application.Interfaces;
using ApartmentManagement.Application.Dto;

namespace ApartmentManagement.Web.Controllers
{
    public class OrderController : Controller
    {
        private readonly ICreditCardService _creditCardService;
        public OrderController(ICreditCardService creditCardService)
        {
            _creditCardService = creditCardService;
        }
        public IActionResult Index()
        {
            return View();
        }

  
        public async Task<IActionResult> Payment()
        {

            var currentBasket = HttpContext.Session.Get<HousingAddDto>("housing");

            return View(currentBasket);
        }

        [HttpPost]
        public async Task<IActionResult> Payment(CreditCardDto creditCard)
        {
            bool result = await _creditCardService.WithdrawMoney(creditCard);
            return View();
        }

        public IActionResult Basket()
        {
            var currentBasket = HttpContext.Session.Get<HousingAddDto>("housing");

            return View(currentBasket);
        }

        public IActionResult BasketAdd(int id)
        {
            var currentBasket = HttpContext.Session.Get<HousingAddDto>("housing");
            if (currentBasket == default)
            {
                HousingAddDto housingView = new HousingAddDto();
                housingView.Items = new List<BlockAddDto>();
                housingView.Items.Add(new HousingAddDto {HousingId = id });

                HttpContext.Session.Set<HousingAddDto>("housing", housingView);
            }
            else
            {
                var currentItem = currentBasket.Items.FirstOrDefault(x => x.ProductId == id);
                if (currentItem == null)
                {
                    currentHousing.Items.Add(new HousingAddDto { HousingId = id);

                    
                }
                else
                {
                    currentItem.Piece++;
                }

                HttpContext.Session.Set<HousingAddDto>("housing", currentHousingt);
            }


            return Ok(new { status=true });
        }
    }
}
