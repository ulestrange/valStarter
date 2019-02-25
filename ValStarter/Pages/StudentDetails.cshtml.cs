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
    public class StudentDetailsModel : PageModel
    {

        private readonly CollegeContext _db;

        [BindProperty]
        public Student Student { get; set; }

        public StudentDetailsModel(CollegeContext db)
        {
            _db = db;
        }



        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                Student = await _db.Students.FirstOrDefaultAsync();
            }
            else
            {
                Student = await _db.Students.FirstOrDefaultAsync(s => s.StudentID == id);
            }

            if (Student == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {

            var student = await _db.Students.FindAsync(Student.StudentID);

            if (student != null)
            {
                _db.Students.Remove(student);
                await _db.SaveChangesAsync();
            }

            return RedirectToPage("ListStudents");
        }
    }
}