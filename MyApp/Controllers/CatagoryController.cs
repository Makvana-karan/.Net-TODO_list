using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MyApp.Data;
using MyWeb;
using System.Numerics;

namespace MyApp.Controllers
{
    public class CatagoryController : Controller

    {
        private DataContext _context;

        public CatagoryController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            IEnumerable<Catagory> catagories = _context.Catagories;
            return View(catagories);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Catagory catagory)
        {
            if (ModelState.IsValid)
            {
                _context.Catagories.Add(catagory);
                _context.SaveChanges();
                TempData["Successs"] = "Catagory Created...";
                return RedirectToAction("Index");
            }
            return View(catagory);
        }

        [HttpGet]
        public IActionResult Edit(int? id) 
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }
            var catagory = _context.Catagories.Find(id);
            if (catagory == null) 
            {
                return NotFound();
            }
            return View(catagory);
        }

       [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Catagory catagory) 
        {
            if (ModelState.IsValid) 
            {
                _context.Catagories.Update(catagory);
                _context.SaveChanges();
                TempData["Success"] = "Catagory Updated...";
                return RedirectToAction("Index");
            }
            return View("Index");
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var catagory = _context.Catagories.Find(id);
            if (catagory == null)
            {
                return NotFound();
            }
            return View(catagory);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(Catagory catagory) 
        {
            if (ModelState.IsValid) 
            {
                _context.Catagories.Remove(catagory);
                _context.SaveChanges();
                TempData["success"] = "Catagory Deleted...";
                return RedirectToAction("Index");
            }
            return View("Index");
        }
    }
}
