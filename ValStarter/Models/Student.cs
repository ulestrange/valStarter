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
        public string StudentID { get; set; }

       
        public string FirstName { get; set; }

       
        public string LastName { get; set; }
    }
}
