using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ClinicaDoctoriSpecializari.Data;
using ClinicaDoctoriSpecializari.Models;

namespace ClinicaDoctoriSpecializari.Pages.Doctori
{
    public class CreateModel : PageModel
    {
        private readonly ClinicaDoctoriSpecializari.Data.ClinicaDoctoriSpecializariContext _context;

        public CreateModel(ClinicaDoctoriSpecializari.Data.ClinicaDoctoriSpecializariContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["ClinicaID"] = new SelectList(_context.Clinica, "ID", "Nume");
        ViewData["SpecializareID"] = new SelectList(_context.Specializare, "ID", "Nume");
            return Page();
        }

        [BindProperty]
        public Doctor Doctor { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Doctor.Add(Doctor);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
