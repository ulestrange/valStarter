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


        [GraduationCohort (ErrorMessage ="messing")]
        public string GraduationCohort { get; set; }


        [Required]
        [DataType (DataType.Date)]
        [ApplicaitonDate]

        public DateTime? ApplicationDate { get; set; }


    }
}
