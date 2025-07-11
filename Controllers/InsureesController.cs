using Microsoft.AspNetCore.Mvc;
using CarInsurance.Models;
using CarInsurance.Data;
using System.Linq;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private readonly InsuranceDbContext _context;
        public InsureeController(InsuranceDbContext context)
        {
            _context = context;
        }

        // INDEX
        public IActionResult Index()
        {
            var list = _context.Insurees.ToList();
            return View(list);
        }

        // CREATE GET
        public IActionResult Create()
        {
            return View();
        }

        // CREATE POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                insuree.Quote = CalculateQuote(insuree);
                _context.Add(insuree);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(insuree);
        }

        // DETAILS
        public IActionResult Details(int? id)
        {
            if (id == null) return NotFound();
            var insuree = _context.Insurees.Find(id);
            if (insuree == null) return NotFound();
            return View(insuree);
        }

        // EDIT GET
        public IActionResult Edit(int? id)
        {
            if (id == null) return NotFound();
            var insuree = _context.Insurees.Find(id);
            if (insuree == null) return NotFound();
            return View(insuree);
        }

        // EDIT POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Insuree insuree)
        {
            if (id != insuree.Id) return BadRequest();
            if (ModelState.IsValid)
            {
                insuree.Quote = CalculateQuote(insuree);
                _context.Update(insuree);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(insuree);
        }

        // DELETE GET
        public IActionResult Delete(int? id)
        {
            if (id == null) return NotFound();
            var insuree = _context.Insurees.Find(id);
            if (insuree == null) return NotFound();
            return View(insuree);
        }

        // DELETE POST
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var insuree = _context.Insurees.Find(id);
            _context.Remove(insuree);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        // ADMIN - custom view
        public IActionResult Admin()
        {
            var all = _context.Insurees.ToList();
            return View(all);
        }

        private decimal CalculateQuote(Insuree i)
        {
            decimal quote = 50m;
            int age = System.DateTime.Now.Year - i.DateOfBirth.Year;
            if (i.DateOfBirth > System.DateTime.Now.AddYears(-age)) age--;

            if (age <= 18) quote += 100;
            else if (age <= 25) quote += 50;
            else quote += 25;

            if (i.CarYear < 2000) quote += 25;
            if (i.CarYear > 2015) quote += 25;

            if (i.CarMake?.ToLower() == "porsche")
            {
                quote += 25;
                if (i.CarModel?.ToLower() == "911 carrera") quote += 25;
            }

            quote += i.SpeedingTickets * 10;

            if (i.DUI) quote *= 1.25m;
            if (i.CoverageType) quote *= 1.50m;

            return System.Math.Round(quote, 2);
        }
    }
}
