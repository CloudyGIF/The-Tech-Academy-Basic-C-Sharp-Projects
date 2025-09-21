using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CarInsurance2.Controllers.Data;
using CarInsurance2.Models;

namespace CarInsurance2.Controllers
{
    public class InsureesController : Controller
    {
        private readonly InsuranceContext _context;

        public InsureesController(InsuranceContext context)
        {
            _context = context;
        }

        // GET: Insurees
        public async Task<IActionResult> Index()
        {
            return View(await _context.Insuree.ToListAsync());
        }

        // GET: Insurees/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var insuree = await _context.Insuree
                .FirstOrDefaultAsync(m => m.id == id);
            if (insuree == null)
            {
                return NotFound();
            }

            return View(insuree);
        }

        // GET: Insurees/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Insurees/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,FirstName,LastName,EmailAdress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                insuree.id = Guid.NewGuid();

                insuree.Quote = QuoteCalculation(insuree);

                _context.Add(insuree);
                await _context.SaveChangesAsync();
                return RedirectToAction("ThankYou","Home");
            }
            return View(insuree);
        }

        private decimal QuoteCalculation(Insuree insuree)
        {
           decimal Rate = 50;

            int age = DateTime.Now.Year - insuree.DateOfBirth.Year;
            DateOnly today = DateOnly.FromDateTime(DateTime.Now);
            if (insuree.DateOfBirth > today.AddYears(-age))
            {
                age--;
            }
         

            if(age <= 18)
            {
                Rate = Rate + 100;
            } else if (age >= 19 && age <= 25)
            {
                Rate = Rate + 50;
            } else
            {
                Rate = Rate + 25;

            }

            

            if(insuree.CarYear < 2000)
            {
                Rate = Rate + 25;
            }
            else if (insuree.CarYear > 2015)
            {
                Rate = Rate + 25;
            }

           

            if (insuree.CarMake!.ToLower() == "porsche" && !(insuree.CarModel!.ToLower() == "911 Carrera"))
            {
                Rate = Rate + 25;
            } else if(insuree.CarMake!.ToLower() == "porsche" && insuree.CarModel!.ToLower() == "911 Carrera")
            {
                Rate = Rate + 50;
            }

            

            Rate = Rate + insuree.SpeedingTickets * 10;

         

            if (insuree.DUI)
            {
                Rate = Rate * 1.25m;
            }

            if(insuree.CoverageType.ToString() == "FullCoverage")
            {
                Rate = Rate * 1.5m;
            }

            return Rate;
        }

        // GET: Insurees/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var insuree = await _context.Insuree.FindAsync(id);
            if (insuree == null)
            {
                return NotFound();
            }
            return View(insuree);
        }

        // POST: Insurees/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("id,FirstName,LastName,EmailAdress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (id != insuree.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(insuree);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InsureeExists(insuree.id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(insuree);
        }

        // GET: Insurees/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var insuree = await _context.Insuree
                .FirstOrDefaultAsync(m => m.id == id);
            if (insuree == null)
            {
                return NotFound();
            }

            return View(insuree);
        }

        // POST: Insurees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var insuree = await _context.Insuree.FindAsync(id);
            if (insuree != null)
            {
                _context.Insuree.Remove(insuree);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InsureeExists(Guid id)
        {
            return _context.Insuree.Any(e => e.id == id);
        }
    }
}
