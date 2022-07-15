using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using app.Models;

namespace app.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProductDbContext _db;
        public HomeController(ProductDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View(_db.Products);
        }

        public IActionResult Show(int? id)
        {
            if (id == null || _db.Products == null) return NotFound();
            var pr = _db.Products.FirstOrDefault(p => p.ProductCode == id);
            return View(pr);
        }

        public IActionResult insert()
        {
            ViewData["Products"] = new SelectList(_db.Products, "ProductCode", "Name");
            return View();
        }

        [HttpPost]
        public IActionResult insert(Product product)
        {
            if (ModelState.IsValid && _db.Products != null)
            {
                _db.Products.Add(product);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult insert2()
        {
            ViewData["Products"] = new SelectList(_db.Products, "ProductCode", "Name");
            return View();
        }

        [HttpPost]
        public IActionResult insert2(ProductViewModel pr)
        {
            if (ModelState.IsValid)
            {
                Product product = new Product()
                {
                    ProductCode = pr.ProductCode,
                    Name = pr.Name,
                    Price = pr.Price,
                    Description = pr.Description,
                };

                if (pr.Image != null)
                    product.ImageName = pr.ProductCode + Path.GetExtension(pr.Image.FileName);

                else
                    product.ImageName = "DefaultImage.jpg";
                if (_db.Products != null)
                {
                    _db.Products.Add(product);
                    _db.SaveChanges();
                }

                if (pr.Image?.Length > 0)
                {
                    string FilePath = Path.Combine(Directory.GetCurrentDirectory(),
                        "wwwroot", "images", product.ImageName);
                    using (var stream = new FileStream(FilePath, FileMode.Create))
                    {
                        pr.Image.CopyTo(stream);
                    }
                }

                return RedirectToAction("Index");
            }
            return View();
        }
    }
}