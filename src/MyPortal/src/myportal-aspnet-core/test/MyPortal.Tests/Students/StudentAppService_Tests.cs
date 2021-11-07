using System.Collections.Generic;
using System.Threading.Tasks;
using MyPortal.Students;
using MyPortal.Students.Dtos;
using Shouldly;
using Xunit;

namespace MyPortal.Tests.Students
{
    public class StudentAppService_Tests: MyPortalTestBase
    {
        private readonly IStudentAppService _studentAppService;

        public StudentAppService_Tests(IStudentAppService studentAppService)
        {
            _studentAppService = studentAppService;
        }

        [Fact]
        public async Task Should_Get_All_Students()
        {
            var output = await _studentAppService.GetAllAsync(new PagedStudentResultRequestDto());

            output.Items.Count.ShouldBe(1);
        }
    }
}
