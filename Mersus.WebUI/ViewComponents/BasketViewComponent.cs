using Mersus.Core.Interfaces;
using Mersus.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mersus.WebUI.ViewComponents
{
    public class BasketViewComponent : ViewComponent
    {
        IBasketRepo _basketRepo;
        public BasketViewComponent(IBasketRepo basketRepo)
        {
            _basketRepo = basketRepo;
        }

        public ViewViewComponentResult Invoke()
        {
            var model = new BasketViewModel
            {
                Basket = _basketRepo.GetAll().FirstOrDefault()
            };

            return View(model);
        }

    }
}
