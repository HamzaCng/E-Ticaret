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
    public class CategoryViewComponent : ViewComponent
    {
        ICategoryRepo _categoryRepository;

        public CategoryViewComponent(ICategoryRepo categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public ViewViewComponentResult Invoke()
        {
            var model = new CategoryListViewModel
            {
                //Kategori listemizi partial kullanmak istediğimizi varsayalım.
                Categories = _categoryRepository.GetAll().ToList()

            };

            return View(model);
        }
    }
}
