using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ClinicaDoctoriSpecializari.Data;
using ClinicaDoctoriSpecializari.Models;

namespace ClinicaDoctoriSpecializari.Pages.Clinici
{
    public class EditModel : PageModel
    {
        private readonly ClinicaDoctoriSpecializari.Data.ClinicaDoctoriSpecializariContext _context;

        public EditModel(ClinicaDoctoriSpecializari.Data.ClinicaDoctoriSpecializariContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Clinica Clinica { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Clinica = await _context.Clinica.FirstOrDefaultAsync(m => m.ID == id);

            if (Clinica == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Clinica).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClinicaExists(Clinica.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ClinicaExists(int id)
        {
            return _context.Clinica.Any(e => e.ID == id);
        }
    }
}
