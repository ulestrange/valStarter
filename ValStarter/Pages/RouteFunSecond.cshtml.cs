using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ValStarter.Pages
{
    public class RouteFunSecondModel : PageModel
    {
        [BindProperty (SupportsGet = true)]
        public string Message { get; set; }

        // public string Mess;
        //public void OnGet(string message)
        //{
        //    Mess = message;
        //}
    }
}