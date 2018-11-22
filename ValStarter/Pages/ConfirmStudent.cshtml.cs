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
    public class ConfirmStudentModel : PageModel
    {

        public Student Student = new Student();


        public void OnGet()
        {
            var response = TempData.Get<Student>("Student");
            TempData.Keep();

            if (response != null)
            {
                Student = response;
            }
          
        }
    }
}