using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentManagement.Data;
using StudentManagement.Models;
using StudentManagement.Models.Entities;

namespace StudentManagement.Controllers
{
    public class StudentController1 : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public StudentController1(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Add(AddStudentViewModel viewModel)
        {
            var student = new Student
            {
                Name = viewModel.Name,
                Email = viewModel.Email,
                CGPA = viewModel.CGPA,
                RollNumber = viewModel.RollNumber
            };
            await dbContext.GGStudent.AddAsync(student);

            dbContext.SaveChanges();
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            var student = await dbContext.GGStudent.ToListAsync();

            return View(student);

        }
    }
}
