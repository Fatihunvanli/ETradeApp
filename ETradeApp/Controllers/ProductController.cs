using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ETradeApp.Models;
using ETradeApp.Repository.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ETradeApp.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository _productRepository;
        private ICategoryRepository _categoryRepository;
        private IPictureRepository _pictureRepository;
        public ProductController(IProductRepository productRepository, ICategoryRepository categoryRepository, IPictureRepository pictureRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
            _pictureRepository = pictureRepository;
        }
        public IActionResult Index(int category = 0)
        {
            List<Product> model = category > 0 ? _productRepository.GetList().Where(x => x.CategoryId == category).ToList() : _productRepository.GetList();

            return PartialView("_ProductListPartial",model);
        }

        public IActionResult ProductDetail(int id)
        {
            var model = _productRepository.Get(p => p.Id == id);

            return View(model);
        }

        public IActionResult ProductDelete(int id)
        {
            var product = _productRepository.Get(p => p.Id == id);

            _productRepository.Delete(product);
            TempData["Danger"] = "Ürün Silindi";

            return RedirectToAction("ProductManagement", "Management");
        }
        [HttpGet]
        public IActionResult ProductAdd()
        {
            var categories = _categoryRepository.GetList();

            List<SelectListItem> categorySelectList = new List<SelectListItem>();

            foreach (var item in categories)
            {
                categorySelectList.Add(new SelectListItem() { Text = item.CategoryName, Value = item.Id.ToString(), Selected = (item.Id == 1 ? true : false), });
            }

            ViewBag.Catagories = categorySelectList;

            return View();
        }
        [HttpPost]
        public IActionResult ProductAdd(Product product, IFormFile[] photos)
        {
            if (photos == null || photos.Length == 0)
            {
                return Content("Dosya seçilmedi.");
            }
            else
            {
                _productRepository.Add(product);
                //product.Pictures = new List<string>();
                foreach (IFormFile photo in photos)
                {
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img", photo.FileName);
                    var stream = new FileStream(path, FileMode.Create);
                    photo.CopyToAsync(stream);

                    var model = new Picture { ProductId = product.Id, PictureName = photo.FileName };
                    _pictureRepository.Add(model);
                    //product.Pictures.Add(photo.FileName);
                }
                TempData["Success"] = "Ürün Eklendi.";
            }

            return RedirectToAction("ProductManagement","Management");
        }

        [HttpGet]
        public IActionResult ProductUpdate(int id)
        {
            var model = _productRepository.Get(p => p.Id == id);

            var categories = _categoryRepository.GetList();

            List<SelectListItem> categorySelectList = new List<SelectListItem>();

            foreach (var item in categories)
            {
                categorySelectList.Add(new SelectListItem() { Text = item.CategoryName, Value = item.Id.ToString(), Selected = (item.Id == 1 ? true : false), });
            }

            ViewBag.Catagories = categorySelectList;

            return View(model);
        }
        [HttpPost]
        public IActionResult ProductUpdate(Product product)
        {

            _productRepository.Update(product);
            TempData["Success"] = "Ürün Güncellendi.";

            return RedirectToAction("ProductManagement", "Management");
        }

    }
}
