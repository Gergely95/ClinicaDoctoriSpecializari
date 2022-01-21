using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicaDoctoriSpecializari.Models
{
    public class Specializare
    {
        public int ID { get; set; }
        [RegularExpression(@"^[a-zA-Z''-'\s]{3,40}$",
         ErrorMessage = "Introduceti litere, minim = 3, maxim = 50"), Required]
        public string Nume { get; set; }
        [RegularExpression(@"^[0-9''-'\s]{3,40}$",
         ErrorMessage = "Introduceti cifre, minim = 3, maxim = 50"), Required]
        public int aniStudiu { get; set; }
    }
}
