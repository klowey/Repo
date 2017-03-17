using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NewResume.Data;
using NewResume.Models.EmployerJobViewModel;

namespace NewResume.Controllers
{
    public class EmployerJobViewModelsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmployerJobViewModelsController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: EmployerJobViewModels
        public async Task<IActionResult> Index(int ? id, int ? EmployerId, int ? JobId)
        {
            var viewModel = new EmployerJobViewModel();

                return View(await _context.Employer.ToListAsync());
        }

        // GET: EmployerJobViewModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            if (!EmployerJobViewModelExists((int)id))
            {
                return NotFound();
            }

            EmployerJobViewModel employerJobViewModel = new EmployerJobViewModel();
            employerJobViewModel.Employer = await _context.Employer.SingleOrDefaultAsync(e => e.EmployerId == id);
            employerJobViewModel.Jobs = await _context.Job.Where(j => j.EmployerId == id).ToListAsync();
            employerJobViewModel.JobDuties = await _context.JobDuty.Where(d => d.JobId == id).ToListAsync();                 
                              
                
             //await _context.EmployerJobViewModel.SingleOrDefaultAsync(m => m.Id == id);
            if (employerJobViewModel == null)
            {
                return NotFound();
            }

            return View(employerJobViewModel);
        }

        // GET: EmployerJobViewModels/View

        public async Task<IActionResult> View(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //if (!EmployerJobViewModelExists((int)id))
            //{
            //    return NotFound();
            //}
            EmployerJobViewModel employerJobViewModel = new EmployerJobViewModel();
            employerJobViewModel.Employer = await _context.Employer.SingleOrDefaultAsync(e => e.EmployerId == id);
            employerJobViewModel.Jobs = await _context.Job.Where(j => j.JobId == id).ToListAsync();
            employerJobViewModel.JobDuties = await _context.JobDuty.Where(d => d.JobId ==id)
            //    .Include(d => d.JobId)
                .ToListAsync();

            if (employerJobViewModel == null)
            {
                return NotFound();
            }

            ViewData["Title"] = employerJobViewModel.Jobs.Where(j => j.JobId == id).First().JobTitle;
            return View(employerJobViewModel);
        }

        // GET: EmployerJobViewModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EmployerJobViewModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id")] EmployerJobViewModel employerJobViewModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(employerJobViewModel);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(employerJobViewModel);
        }

        // GET: EmployerJobViewModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employerJobViewModel = await _context.EmployerJobViewModel.SingleOrDefaultAsync(m => m.Id == id);
            if (employerJobViewModel == null)
            {
                return NotFound();
            }
            return View(employerJobViewModel);
        }

        // POST: EmployerJobViewModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id")] EmployerJobViewModel employerJobViewModel)
        {
            if (id != employerJobViewModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(employerJobViewModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployerJobViewModelExists(employerJobViewModel.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(employerJobViewModel);
        }

        // GET: EmployerJobViewModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employerJobViewModel = await _context.EmployerJobViewModel.SingleOrDefaultAsync(m => m.Id == id);
            if (employerJobViewModel == null)
            {
                return NotFound();
            }

            return View(employerJobViewModel);
        }

        // POST: EmployerJobViewModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employerJobViewModel = await _context.EmployerJobViewModel.SingleOrDefaultAsync(m => m.Id == id);
            _context.EmployerJobViewModel.Remove(employerJobViewModel);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool EmployerJobViewModelExists(int id)
        {
            return _context.Employer.Any(e => e.EmployerId == id);
        }
    }
}
