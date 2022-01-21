using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicaDoctoriSpecializari.Models
{
    public class Doctor
    {
        public int ID { get; set; }
        [RegularExpression(@"^[a-zA-Z''-'\s]{3,40}$",
         ErrorMessage = "Introduceti litere, minim = 3, maxim = 50"), Required]
        public string nume { get; set; }
        [RegularExpression(@"^[a-zA-Z''-'\s]{3,40}$",
         ErrorMessage = "Introduceti litere, minim = 3, maxim = 50"), Required]
        public string prenume { get; set; }
        public int ClinicaID { get; set; }
        [Display(Name = "Clinica")]
        public Clinica clinica { get; set;}
        public int SpecializareID { get; set; }
        [Display(Name = "Specializare")]
        public Specializare specializare { get; set; }
    }
}
