using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mersus.Core.Interfaces;
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


        public IActionResult Index()
        {
            return Json(_productRepository.GetAll());
        }

        [HttpPost]
        public  IActionResult AddProduct()
        {

            return View();
        }


    }
}
