using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ETradeApp.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace ETradeApp.Controllers
{
    public class ManagementController : Controller
    {
        private IProductRepository _productRepository;
        private ICategoryRepository _categoryRepository;

        public ManagementController(IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CategoryManagement()
        {
            var model = _categoryRepository.GetList();

            return View(model);
        }

        public IActionResult ProductManagement()
        {
            var model = _productRepository.GetList();

            return View(model);
        }
    }
}
