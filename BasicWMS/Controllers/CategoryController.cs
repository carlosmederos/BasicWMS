using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using BasicWMS.Model;
using BasicWMS.Service.Interfaces;
using BasicWMS.ViewModels;

namespace BasicWMS.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [ChildActionOnly]
        public PartialViewResult MenuCategories(int selectedCategoryId)
        {
            var categories = _categoryService.GetCategories();
            var categoriesViewModels = Mapper.Map<IEnumerable<Category>, IEnumerable<CategoryViewModel>>(categories);
            ViewBag.SelectedCategoryId = selectedCategoryId;

            return PartialView(categoriesViewModels);
        }
    }
}
