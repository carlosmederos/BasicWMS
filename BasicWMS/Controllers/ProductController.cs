using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using BasicWMS.Model;
using BasicWMS.Service;
using BasicWMS.Service.Interfaces;
using BasicWMS.ViewModels;
using PagedList;

namespace BasicWMS.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        

        public ProductController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        //
        // GET: /Product/

        public ActionResult Index(int? page, int categoryId = 0)
        {
            IEnumerable<Product> products = _productService.GetProducts().ToList();
//            IEnumerable<Product> products = _productService.GetProductForPage(9, page ?? 1).ToList();
            if (categoryId != 0)
            {
                products = _categoryService.GetProductsByCategory(categoryId);
            }

//            products = products.ToPagedList(page ?? 1, 9);
           
            //Mapper
            var productsViewModels = Mapper.Map<IEnumerable<Product>, IEnumerable<ProductViewModel>>(products);
            return View(productsViewModels.ToPagedList(page ?? 1, 9));
        }
        

        //
        // GET: /Product/Details/5

        public ActionResult Details(int id = 0)
        {
            var product = _productService.GetProduct(id);
            var productViewModels = Mapper.Map<Product, ProductViewModel>(product);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(productViewModels);
        }

        //
        // GET: /Product/Create

        public ActionResult Create()
        {
            return View("Create", new ProductViewModel());
        }

        //
        // POST: /Product/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProductViewModel productViewModel)
        {
            if (ModelState.IsValid)
            {
                var product = Mapper.Map<ProductViewModel, Product>(productViewModel);
                _productService.CreateProduct(product);
                return RedirectToAction("Index");
            }

            return View(productViewModel);
        }

        //
        // GET: /Product/Edit/5

        public ActionResult Edit(int id = 0)
        {
            var product = _productService.GetProduct(id);
            var productViewModel = Mapper.Map<Product, ProductViewModel>(product);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(productViewModel);
        }

        //
        // POST: /Product/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ProductViewModel productViewModel)
        {
            if (ModelState.IsValid)
            {
                var product = Mapper.Map<ProductViewModel, Product>(productViewModel);
                _productService.UpdateProduct(product);
                return RedirectToAction("Index");
            }
            return View(productViewModel);
        }

        //
        // GET: /Product/Delete/5

        public ActionResult Delete(int id = 0)
        {
            var product = _productService.GetProduct(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            var productViewModel = Mapper.Map<Product, ProductViewModel>(product);
            return View(productViewModel);
        }

        //
        // POST: /Product/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var product = _productService.GetProduct(id);
            _productService.DeleteProduct(product);
            return RedirectToAction("Index");
        }
        /*
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
        */
    }
}