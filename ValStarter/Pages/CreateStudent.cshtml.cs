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
        private readonly CollegeContext _db;

        public CreateStudentModel(CollegeContext db)
        {
            _db = db;
        }

        [BindProperty]

        public Student Student { get; set; } = new Student();
        public void OnGet()
        {
            

            Student.StudentID = HttpContext.Session.GetString("StudentID");
            Student.FirstName = HttpContext.Session.GetString("FirstName");
            Student.LastName = HttpContext.Session.GetString("LastName");


        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                // Note: This only works because all of the fields are required
                // so all of the string are non null.
                // Otherwise we would need to check for non null.

                HttpContext.Session.SetString("FirstName", Student.FirstName);
                HttpContext.Session.SetString("LastName", Student.LastName);
                HttpContext.Session.SetString("StudentID", Student.StudentID);

                _db.Students.Add(Student);
                await _db.SaveChangesAsync();

                return RedirectToPage("ConfirmStudent");

            }
            else
            {
                return Page();
            }
        }
    }
}