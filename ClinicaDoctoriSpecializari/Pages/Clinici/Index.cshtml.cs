using System;
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
    public class IndexModel : PageModel
    {
        private readonly ClinicaDoctoriSpecializari.Data.ClinicaDoctoriSpecializariContext _context;

        public IndexModel(ClinicaDoctoriSpecializari.Data.ClinicaDoctoriSpecializariContext context)
        {
            _context = context;
        }

        public IList<Clinica> Clinica { get;set; }

        public async Task OnGetAsync()
        {
            Clinica = await _context.Clinica.ToListAsync();
        }
    }
}
