﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ClinicaDoctoriSpecializari.Data;
using ClinicaDoctoriSpecializari.Models;

namespace ClinicaDoctoriSpecializari.Pages.Clinici
{
    public class DeleteModel : PageModel
    {
        private readonly ClinicaDoctoriSpecializari.Data.ClinicaDoctoriSpecializariContext _context;

        public DeleteModel(ClinicaDoctoriSpecializari.Data.ClinicaDoctoriSpecializariContext context)
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Clinica = await _context.Clinica.FindAsync(id);

            if (Clinica != null)
            {
                _context.Clinica.Remove(Clinica);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
