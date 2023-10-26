using lab3.Contexts;
using lab3.Models;
using Microsoft.AspNetCore.Mvc;

namespace lab3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private StudentContext _studentContext;

        public StudentController(StudentContext students)
        {
            _studentContext = students;
        }
        [HttpGet]
        public List<Student> Index()
        {
            return _studentContext.Students.ToList(); 
        }


    }
}
