using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ValStarter.Pages
{
    public class SampleModel : PageModel
    {

        public string Dummy { get; set; }
        public void OnGet()
        {

            CookieOptions options = new CookieOptions();
            options.Expires = DateTime.Now.AddYears(1);

            Response.Cookies.Append("UnaCookie", "Welcome back", options);


        }
    }
}