using Microsoft.AspNetCore.Mvc;
using Practical9.Models;
using Practical9.Services;

namespace Practical9.Controllers
{
    public class StudentsController : Controller
    {
        private readonly IStudentService _studentService;
        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        public IActionResult Index()
        {
            return View(_studentService.GetAll());
        }

        public IActionResult Details(int id)
        {
            var student = _studentService.GetById(id);
            if (student == null)
                return NotFound();
            return View(student);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(StudentCreateModel model)
        {
            if (!ModelState.IsValid)
                return View(model);
            _studentService.Add(model);
            return RedirectToAction("Index");
        }
    }
}
