using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ValStarter.Models;
using Microsoft.AspNetCore.Http;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ValStarter.Controllers
{
    [Route("data/[controller]")]
    [ApiController]
    public class DisplayController : ControllerBase
    {
        private readonly CollegeContext _db;

        public DisplayController(CollegeContext db)
        {
            _db = db;
        }



        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Student>> GetStudent(string id)
        {
            var student = await _db.Students.FindAsync(id);

            if (student == null)
            {
                return NotFound();
            }

            return student;
        }
    }
}
