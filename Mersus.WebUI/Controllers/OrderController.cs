using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mersus.Core.Interfaces;
using Mersus.WebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Mersus.WebUI.Controllers
{
    public class OrderController : Controller
    {
        IOrderRepo _orderRepository;

        public OrderController(IOrderRepo orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public IActionResult GetOder(OrderViewModel model)
        {
            var order = _orderRepository.GetSingle(model.Id);
            if (order != null)
            {
                order.OrderItems = model.OrderItems;
            }           

            return View(model);
        }
    }
}
