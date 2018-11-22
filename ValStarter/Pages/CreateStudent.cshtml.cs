using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ValStarter.Models;
using ValStarter.Shared;


namespace ValStarter.Pages
{
    public class CreateStudentModel : PageModel
    {

        [BindProperty]
      //  [TempData]

        public Student Student { get; set; } = new Student();
        public void OnGet()
        {


            var response = TempData.Get<Student>("Student");


            if (response != null)
            {
                Student = response;
            }

        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                // Note: This only works because all of the fields are required
                // so all of the string are non null.
                // Otherwise we would need to check for non null.

                TempData.Set("Student", Student);


                return RedirectToPage("ConfirmStudent");

            }
            else
            {
                return Page();
            }
        }
    }
}