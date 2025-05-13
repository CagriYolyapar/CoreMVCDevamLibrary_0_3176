using CoreMVCDevam_0.Models.ContextClasses;
using CoreMVCDevam_0.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CoreMVCDevam_0.Controllers
{
    public class CategoryController : Controller
    {
        readonly MyContext _context;
        public CategoryController(MyContext context)
        {
            _context = context;
            
        }
        public IActionResult CategoryList()
        {
           
            return View(_context.Categories.ToList());
        }

        public IActionResult CreateCategory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateCategory(Category category)
        {
            _context.Categories.Add(category);  
            _context.SaveChanges();
            return RedirectToAction("CategoryList");
        }

        public IActionResult UpdateCategory(int id)
        {
            return View(_context.Categories.Find(id));
        }

        [HttpPost]
        public IActionResult UpdateCategory(Category category)
        {
            Category original = _context.Categories.Find(category.Id);
            original.CategoryName = category.CategoryName;
            original.UpdatedDate = DateTime.Now;
            original.Status = Models.Enums.DataStatus.Updated;
            _context.SaveChanges();
            return RedirectToAction("CategoryList");
        }

        public IActionResult DeleteCategory(int id)
        {
            _context.Categories.Remove(_context.Categories.Find(id));
            _context.SaveChanges();
            return RedirectToAction("CategoryList");
        }
    }
}
