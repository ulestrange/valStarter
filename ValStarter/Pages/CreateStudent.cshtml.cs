using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using ValStarter.Models;

namespace ValStarter.Pages
{
    public class CreateStudentModel : PageModel
    {

        [BindProperty]

        public Student Student { get; set; } = new Student();
        public void OnGet()
        {
            // This checks whether there is a "student" object saved
            // in the Session.
            // If so it takes it out, and uses it for the student
            // The fact that the Student property is bound means the values
            // from the object will be already filled in when the page appears.

            var value = HttpContext.Session.GetString("student");
            if (value != null)
            {
                Student = JsonConvert.DeserializeObject<Student>(value);
                HttpContext.Session.Clear();
            }
           


        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                // This will use Serialisation

                var serialisedData = JsonConvert.SerializeObject(Student);

                HttpContext.Session.SetString("student", serialisedData);
                


                return RedirectToPage("ConfirmStudent");

            }
            else
            {
                return Page();
            }
        }
    }
}