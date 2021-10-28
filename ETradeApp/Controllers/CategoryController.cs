using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ETradeApp.Models;
using ETradeApp.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace ETradeApp.Controllers
{
    public class CategoryController : Controller
    {
        private ICategoryRepository _categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CategoryDelete(int id)
        {
            var category = _categoryRepository.Get(c => c.Id == id);
            _categoryRepository.Delete(category);
            TempData["Danger"] = "Kategori Silindi";

            return RedirectToAction("CategoryManagement","Management");
        }
        [HttpGet]
        public IActionResult CategoryAdd()
        {

            return View();
        }
        [HttpPost]
        public IActionResult CategoryAdd(Category category)
        {
            if (!ModelState.IsValid)
            {
                TempData["Danger"] = "Bir Hata Oluştu.";
                return RedirectToAction("CategoryManagement", "Management");
            }

            var isThere = _categoryRepository.Get(x => x.CategoryName.Equals(category.CategoryName));

            if (isThere.CategoryName != null)
            {
                TempData["Danger"] = "Kategori Mevcut";
                return RedirectToAction("CategoryManagement", "Management");
            }

            _categoryRepository.Add(category);
            TempData["Success"] = "Kategori Eklendi.";

            return RedirectToAction("CategoryManagement", "Management");
        }
        [HttpGet]
        public IActionResult CategoryUpdate(int id)
        {
            if (id == 0 || id == null)
            {
                TempData["Danger"] = "Bir Hata Oluştu.";
                return RedirectToAction("CategoryManagement", "Management");
            }

            var model = _categoryRepository.Get(x => x.Id == id);

            var category = _categoryRepository.Get(c => c.Id == id);
            _categoryRepository.Update(category);

            return View(model);
        }

        [HttpPost]
        public IActionResult CategoryUpdate(Category category)
        {
            
            _categoryRepository.Update(category);
            TempData["Success"] = "Kategori Güncellendi.";

            return RedirectToAction("CategoryManagement", "Management");
        }

    }
}
