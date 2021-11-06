using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
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

        public ActionResult Index() => View();

        public async Task<ActionResult> EditModal(int studentId)
        {
            var tenantDto = await _studentAppService.GetAsync(new EntityDto(studentId));
            return PartialView("_EditModal", tenantDto);
        }
    }
}
