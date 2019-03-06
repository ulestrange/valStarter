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

        [TempData]
        public string Message { get; set; }

        [TempData]
        public string Message2 { get; set; }

        private readonly CollegeContext _db;

        public StudentDetailsModel(CollegeContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Student Student { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            Student = await _db.Students.FindAsync(id);

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

            Message = $"Student {student.StudentID} has been deleted";

            Message2 = $"Student {student.StudentID} has been deleted: Message2";

            return RedirectToPage("ListStudents");
        }
    }
}