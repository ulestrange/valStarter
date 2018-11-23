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
      //  [TempData]

        public Student Student { get; set; } = new Student();
        public void OnGet()
        {


            var response = TempData["Student"];

            if (response != null)
            {
                Student = JsonConvert.DeserializeObject<Student>((string)response);
            }

        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                // Note: This only works because all of the fields are required
                // so all of the string are non null.
                // Otherwise we would need to check for non null.


               // var serialisedData = JsonConvert.SerializeObject(Student);

                TempData["Student"] = JsonConvert.SerializeObject(Student);

                return RedirectToPage("ConfirmStudent");

            }
            else
            {
                return Page();
            }
        }
    }
}