using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebProject.Data;
using WebProject.Models;
using WebProject.Services;
using WebProject.ViewModels;

namespace WebProject.Controllers
{
    public class HomeController : Controller
    {

        private WebProjectDbContex db = new WebProjectDbContex();
        //List<Products> _product;
        IRepository<Products> _productRepo;

        public HomeController(IRepository<Products> Iproduct)
        {

            //_productRepo = new MockProducts();
            _productRepo = Iproduct;

        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Products()
        {
            HomeIndexViewModel model = new HomeIndexViewModel()
            {
                Iproduct = _productRepo.GetAll()
            };

            return View(model);
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string sub)
        {
            return View();
        }
        public IActionResult ProductManagement()
        {
            HomeIndexViewModel model = new HomeIndexViewModel()
            {
                Iproduct = _productRepo.GetAll()

            };
            return View(model);
        }
        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(Products product)
        {
            if (ModelState.IsValid)
            {

                Products item = new Products()
                {
                    ID = _productRepo.GetAll().Max(m => m.ID) + 1,
                    Name = product.Name,
                    Price = product.Price,
                    Details = product.Details,
                    Image = product.Image,
                    Count = product.Count
                };
                _productRepo.Add(item);


                return RedirectToAction("ProductManagement");
            }
            else
            {
                return View();
            }

        }
        [HttpGet]
        public IActionResult EditProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult EditProduct(int id)
        {
            Products product = _productRepo.Get(id);
            return View(product);
        }

        [HttpGet]
        public IActionResult Details()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Details(int id)
        {
            Products product = _productRepo.Get(id);
            return View(product);
        }
        public IActionResult Order(int id)
        {
            return View();
        }

        public IActionResult CreateProduct(Products Pro)
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}