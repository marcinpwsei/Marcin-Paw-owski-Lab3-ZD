using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Marcin_Pawłowski_Lab3_ZD.Models
{
    public class NameFormModel
    {
        private const string polishname = "Imię";

        [Display(Name = polishname)]
        public string Name { get; set; }
        [Required]
        public int Counter { get; set; }
        [Required]

        private const string polishCounter = "Liczba powtórzeń";

        [Display(Name = polishCounter)]
        public int Count
        {
            get
            {
                return Counter += 1;
            }
        }
    }
}
