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
    public class CreateStudentModel : PageModel
    {

        [BindProperty]

        public Student Student { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                HttpContext.Session.SetString("FirstName", Student.FirstName);
                HttpContext.Session.SetString("LastName", Student.LastName);
                HttpContext.Session.SetString("StudentID", Student.StudentID);


                return RedirectToPage("ConfirmStudent");

            }
            else
            {
                return Page();
            }
        }
    }
}