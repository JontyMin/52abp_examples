using Abp.Application.Services.Dto;

namespace MyPortal.Students.Dtos
{
    public class PagedStudentResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }

    }
}
