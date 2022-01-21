using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ClinicaDoctoriSpecializari.Models;

namespace ClinicaDoctoriSpecializari.Data
{
    public class ClinicaDoctoriSpecializariContext : DbContext
    {
        public ClinicaDoctoriSpecializariContext (DbContextOptions<ClinicaDoctoriSpecializariContext> options)
            : base(options)
        {
        }

        public DbSet<ClinicaDoctoriSpecializari.Models.Clinica> Clinica { get; set; }

        public DbSet<ClinicaDoctoriSpecializari.Models.Specializare> Specializare { get; set; }

        public DbSet<ClinicaDoctoriSpecializari.Models.Doctor> Doctor { get; set; }
    }
}
