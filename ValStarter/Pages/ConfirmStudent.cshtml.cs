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
    public class ConfirmStudentModel : PageModel
    {

        public Student Student { get; set; } 

    


        public IActionResult OnGet()
        {
            var value = HttpContext.Session.GetString("student");
            if (value != null)
            {
                Student = JsonConvert.DeserializeObject<Student>(value);
                return Page();
            }
            else
            {
                return RedirectToPage("Error");
            }
        }
    }
}