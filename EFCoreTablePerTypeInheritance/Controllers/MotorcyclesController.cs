using EFCoreTablePerTypeInheritance.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace EFCoreTablePerTypeInheritance.Controllers
{
    public class MotorcyclesController : Controller
    {
        private readonly MyApplicationContext _context;

        public MotorcyclesController(MyApplicationContext context)
        {
            _context = context;
        }


        [HttpGet]
        public IActionResult Index()
        {
            var motorcycles = _context.Motorcycles.AsNoTracking().ToList();
            return View(motorcycles);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Motorcycle motorModel)
        {
            if (ModelState.IsValid)
            {
                _context.Motorcycles.Add(motorModel);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(motorModel);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var motor = GetMotorcycleById(id);
            return View(motor);
        }

        [HttpPost]
        public IActionResult Edit(Motorcycle motorModel)
        {
            if (ModelState.IsValid)
            {
                _context.Motorcycles.Update(motorModel);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(motorModel);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var motor = GetMotorcycleById(id);
            return View(motor);
        }

        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeletePost(int id)
        {
            var motor = GetMotorcycleById(id);
            _context.Motorcycles.Remove(motor);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        private Motorcycle GetMotorcycleById(int id)
        {
            var motor = _context.Motorcycles.SingleOrDefault(x => x.Id == id);
            return motor;
        }
    }
}
