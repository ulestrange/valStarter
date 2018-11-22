using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ValStarter.Models;

namespace ValStarter.Pages
{
    public class ConfirmStudentModel : PageModel
    {
        
        public string StudentID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public void OnGet()
        {
            // this is O.K. because if there is nothing in the Session
            // the values will just be null when they are retrieved.

            StudentID = HttpContext.Session.GetString("StudentID");
            FirstName = HttpContext.Session.GetString("FirstName");
            LastName = HttpContext.Session.GetString("LastName");

        }
    }
}