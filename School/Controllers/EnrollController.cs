using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using School.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Controllers
{
    public class EnrollController : Controller
    {
        private SchoolContext _context;

        public EnrollController(SchoolContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var enroll = await (from s in _context.Students
                                select new EnrollViewModel()
                                {
                                    StudentId = s.StudentId,
                                    StudentName = $"{s.LastName}, {s.FirstName} {s.MiddleName.Substring(0, 1).ToUpper()}"
                                }).ToListAsync();
            return View(enroll);
        }

        public async Task<IActionResult> Edit(int Id)
        {
            var m = await _context.Courses
                    .Where(s => s.StudentCourses.Any(c => c.StudentId == Id))
                    .ToListAsync();            
            return View(m);
        }
    }
}
