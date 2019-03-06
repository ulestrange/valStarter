using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ValStarter.Pages
{
    public class IndexModel : PageModel
    {

        public string Message = "Welcome";
        public void OnGet()
        {
            Response.Cookies.Append("UnaCookie", "Hello World");

            if (Request.Cookies["UnaCookie"] != null)
            {

                Message = "Welcome back";
            }
        }
    }
}
