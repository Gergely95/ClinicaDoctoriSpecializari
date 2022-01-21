using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicaDoctoriSpecializari.Models
{
    public class Clinica
    {
        public int ID { get; set; }
        [RegularExpression(@"^[a-zA-Z''-'\s]{3,40}$",
         ErrorMessage = "Introduceti litere, minim = 3, maxim = 50"), Required]
        public string Nume { get; set; }
        [RegularExpression(@"^[a-zA-Z''-'\s]{3,40}$",
         ErrorMessage = "Introduceti litere, minim = 3, maxim = 50"), Required]
        public string Oras { get; set; }
        [RegularExpression(@"^[a-zA-Z''-'\s]{3,40}$",
         ErrorMessage = "Introduceti litere, minim = 3, maxim = 50"), Required]
        public string Judet { get; set; }
    }
}
