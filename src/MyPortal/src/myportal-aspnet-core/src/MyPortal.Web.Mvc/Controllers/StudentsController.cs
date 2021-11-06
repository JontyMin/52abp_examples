using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyPortal.Controllers;
using MyPortal.Students;

namespace MyPortal.Web.Controllers
{
    public class StudentsController: MyPortalControllerBase
    {
        private readonly IStudentAppService _studentAppService;

        public StudentsController(IStudentAppService studentAppService)
        {
            _studentAppService = studentAppService;
        }

        public async Task<ActionResult> Index()
        {
            var students = await _studentAppService.GetAllStudents();
            
            return View(students);
        }
    }
}
