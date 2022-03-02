using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using productCat.Models;

namespace productCat.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, MyContext dbContext)
        {
            _logger = logger;
            _context = dbContext;
        }
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        // Get AddProduct Page
        [HttpGet("Products")]
        public IActionResult addShowProducts()
        {
            List<Product> allProducts = _context.Products.ToList();
            ViewBag.AllProducts = allProducts;
            return View("AddProduct");
        }

       // Get AddCategory Page
        [HttpGet("Categories")]
        public IActionResult addShowCategories()
        {
            List<Category> allCategories = _context.Categories.ToList();
            ViewBag.AllCategories = allCategories;
            return View("AddCategory");
        }

        // Get OneProduct Page
        [HttpGet("products/{prodId}")]
        public IActionResult addOneProduct(int prodId)
        {
            Product XYZProduct = _context.Products.Include(s => s.MyAssociation).ThenInclude(d => d.Category).FirstOrDefault(a => a.ProductId == prodId);
            ViewBag.AllCategories=_context.Categories.ToList();
            return View("OneProduct", XYZProduct);
            //ViewModel
        }

        // Get OneCategory Page
        [HttpGet("Categories/{catId}")]
        public IActionResult addOneCategory(int catId) //what I need
        {
            Category OneCategory = _context.Categories.Include(s => s.AssociatedBy).ThenInclude(d => d.Product).FirstOrDefault(a => a.CategoryId == catId);
            ViewBag.AllProducts=_context.Products.ToList();
            return View("OneCategory", OneCategory);
        }

        [HttpPost("NewProduct")] //Just adding product
        public IActionResult addNewProduct(Product newProduct)
        {
            List<Product> allProducts = _context.Products.ToList();
            ViewBag.AllProducts = allProducts;
            if(ModelState.IsValid)
            {   
                _context.Add(newProduct);
                _context.SaveChanges();
                Console.WriteLine("Product submitted");
                return RedirectToAction("addShowProducts");
            } else {                
                Console.WriteLine("Product failed to submit");
                return View("AddProduct");
            }
        }

        [HttpPost("NewCategory")] //Just adding category
        public IActionResult addNewCategory(Category newCategory)
        {
            List<Category> allCategories = _context.Categories.ToList();
            ViewBag.AllCategories = allCategories;
            if(ModelState.IsValid)
            {
                _context.Add(newCategory);
                _context.SaveChanges();
                Console.WriteLine("Category submitted");
                return RedirectToAction("addShowCategories");
            } else {
                Console.WriteLine("Category failed to submit");
                return View("AddCategory");
            }
        }

        [HttpPost("NewCatAssoc")] //Add category to product
        public IActionResult catToProd(Association newAssoc)
        {
                _context.Add(newAssoc);
                _context.SaveChanges();
                Console.WriteLine("Category added to product");
                return Redirect($"/products/{newAssoc.ProductId}");
        }

        [HttpPost("NewProdAssoc")] //Add product to category
        public IActionResult prodToCat(Association newAssoc)
        {
                _context.Add(newAssoc);
                _context.SaveChanges();
                Console.WriteLine("Product added to Category");
                return Redirect($"/categories/{newAssoc.CategoryId}");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
