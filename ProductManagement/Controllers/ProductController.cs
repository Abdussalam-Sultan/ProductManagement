using Microsoft.AspNetCore.Mvc;
using ProductManagement.Data;
using ProductManagement.Models;

namespace ProductManagement.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDBContext _db;
        public ProductController(AppDBContext appDBContext)
        {
            _db = appDBContext;
        }
        public IActionResult Index()
        {
            List<Product> products = _db.Products.ToList();
            return View(products);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product product)
        {
            if(!ModelState.IsValid)
            {
                return View(product);
            }
            _db.Products.Add(product);
            _db.SaveChanges();
            TempData["success"] = "Product added successfully";
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Product? obj = _db.Products.Find(id);
            if(obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }
        [HttpPost]
        public IActionResult Edit(Product product)
        {
            if(!ModelState.IsValid)
            {
                return View(product);
            }
            if(product == null || product.Id == 0)
            {
                return NotFound();
            }
            _db.Products.Update(product);
            _db.SaveChanges();
            TempData["success"] = "Product updated successfully";
            return RedirectToAction("Index");
        }
        public IActionResult Detail(int? id)
        {
            Product? obj = _db.Products.Find(id);
            return View(obj);
        }
        public IActionResult Delete(int? id)
        {
            Product? objCategory = _db.Products.Find(id);
            return View(objCategory);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
            Product? obj = _db.Products.Find(id);
            _db.Products.Remove(obj);
            _db.SaveChanges();
            TempData["success"] = "Product deleted successfully";
            return RedirectToAction("Index");
        }
    }
}
