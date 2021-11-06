using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using MyPortal.Students.Dtos;

namespace MyPortal.Students
{
    /// <summary>
    /// 学生应用服务接口
    /// </summary>
    public interface IStudentAppService : IAsyncCrudAppService<StudentDto, int, PagedStudentResultRequestDto,
        CreateStudentDto, StudentDto>
    {

    }
}
