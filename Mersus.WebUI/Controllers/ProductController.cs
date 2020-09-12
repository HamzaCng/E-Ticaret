using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mersus.Core.Interfaces;
using Mersus.Entities.Models;
using Mersus.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Mersus.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private readonly ILogger<ProductController> _logger;
        IProductRepo _productRepository;

        public ProductController(ILogger<ProductController> logger, IProductRepo productRepository)
        {
            _logger = logger;
            _productRepository = productRepository;
        }


        public IActionResult GetProductJson()
        {
            //Burada kayıtlı olan ürünlerimizi Json formatında dönmemiz gerektiğini varsayalım.
            return Json(_productRepository.GetAll());
        }

    }
}
