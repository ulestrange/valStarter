using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
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

        public bool[] SubjectsPicked { get; set; }  = { false, false, false, false };

        [BindNever]
        public string[] SubjectChoices { get; set; } = { "English", "Irish", "Maths", "History" };
    }
}
