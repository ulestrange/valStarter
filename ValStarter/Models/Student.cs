using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ValStarter.Models
{
    public class Student
    {
        [Required]
        public string StudentID { get; set; } = "";

        [Required]
        public string FirstName { get; set; } = "";

        [Required]
        public string LastName { get; set; } = "";

        [Display (Name ="French")]
        public bool TakesFrench { get; set; }

        [Display(Name = "Spanish")]
        public bool TakesSpanish { get; set; }

        [Display(Name = "German")]
        public bool TakesGerman { get; set; }
    }
}
