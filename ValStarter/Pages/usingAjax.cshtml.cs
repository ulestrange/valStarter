using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ValStarter.Models;

namespace ValStarter.Pages
{
    public class UsingAjaxModel : PageModel
    {

        private readonly CollegeContext _db;
      

        public UsingAjaxModel(CollegeContext db)
        {
            _db = db;
        }

        public IList<Student> Students { get; private set; }


        public async Task<IActionResult> OnGetAsync()
        {
            Students = await _db.Students.AsNoTracking().ToListAsync();

            return Page();
        }
    }
}