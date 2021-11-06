

using System.Linq;
using Abp.Application.Services;
using Abp.Domain.Repositories;
using Abp.Extensions;
using Abp.Linq.Extensions;
using MyPortal.Students.Dtos;

namespace MyPortal.Students
{
    public class StudentAppService : AsyncCrudAppService<Student, StudentDto, int, PagedStudentResultRequestDto, CreateStudentDto, StudentDto>, IStudentAppService
    {
        public StudentAppService(IRepository<Student, int> repository) : base(repository)
        {

        }

        protected override IQueryable<Student> CreateFilteredQuery(PagedStudentResultRequestDto input)
        {
            return Repository.GetAll()
                .WhereIf(!input.Keyword.IsNullOrWhiteSpace(), x => x.Name.Contains(input.Keyword));
        }

        protected override void MapToEntity(StudentDto updateInput, Student entity)
        {
            entity.Name = updateInput.Name;
            entity.Address = updateInput.Address;
            entity.Age = updateInput.Age;
        }
    }
}
