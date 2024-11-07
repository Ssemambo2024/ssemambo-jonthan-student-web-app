using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ssemambo_jonthan_student_web_app.Models;

namespace ssemambo_jonthan_student_web_app.Controllers
{
    public class courseUnitsController : Controller
    {
        private readonly studentDbContext _context;

        public courseUnitsController(studentDbContext context)
        {
            _context = context;
        }

        // GET: courseUnits
        public async Task<IActionResult> Index()
        {
            return View(await _context.courseUnits.ToListAsync());
        }

        // GET: courseUnits/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courseUnit = await _context.courseUnits
                .FirstOrDefaultAsync(m => m.Id == id);
            if (courseUnit == null)
            {
                return NotFound();
            }

            return View(courseUnit);
        }

        // GET: courseUnits/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: courseUnits/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CourseUnitCode,Name,DoneInYear")] courseUnit courseUnit)
        {
            if (ModelState.IsValid)
            {
                _context.Add(courseUnit);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(courseUnit);
        }

        // GET: courseUnits/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courseUnit = await _context.courseUnits.FindAsync(id);
            if (courseUnit == null)
            {
                return NotFound();
            }
            return View(courseUnit);
        }

        // POST: courseUnits/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CourseUnitCode,Name,DoneInYear")] courseUnit courseUnit)
        {
            if (id != courseUnit.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(courseUnit);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!courseUnitExists(courseUnit.Id))
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
            return View(courseUnit);
        }

        // GET: courseUnits/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courseUnit = await _context.courseUnits
                .FirstOrDefaultAsync(m => m.Id == id);
            if (courseUnit == null)
            {
                return NotFound();
            }

            return View(courseUnit);
        }

        // POST: courseUnits/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var courseUnit = await _context.courseUnits.FindAsync(id);
            if (courseUnit != null)
            {
                _context.courseUnits.Remove(courseUnit);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool courseUnitExists(int id)
        {
            return _context.courseUnits.Any(e => e.Id == id);
        }
    }
}
